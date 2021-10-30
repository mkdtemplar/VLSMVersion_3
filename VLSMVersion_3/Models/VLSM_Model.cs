using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;
using Microsoft.AspNetCore.Html;
using Microsoft.Data.Sqlite;

namespace VLSMVersion_3.Models
{
    public class Lans
    { 
        public int InitialLanValues { get; set; }
    }
    public class VLSM_Model 
    {
        [Required(ErrorMessage = "Ip address is required")]
        [Display(Name = "IP ADDRESS")]
        public string IP_Address { get; set; }
        [Display(Name = "CIDR VALUE")]
        [Required(ErrorMessage = "CIDR value is required")]
        public int cidrValue { get; set; }
        public List<Lans> LansValues { get; set; }
        public List<string> FinalResult { get; set; }

        private IRepositoryManager _repository;
        public VLSM_Model()
        {
            
            LansValues = new List<Lans>();
        }

        public VLSM_Model(IRepositoryManager repository)
        {
            _repository = repository;
        }
        public int[] subnets = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };
        public int[] hosts = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };
        public int[] submask = { 24, 25, 26, 27, 28, 29, 30, 31, 32 };
        public int[] cidrLastOctet = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

        public List<int> LanHostList { get; set; }
        public List<int> HostsPerLan { get; set; }
        
        public IPAddress IP()
        {
            IPAddress iPAddress = IPAddress.Parse(IP_Address);
            return iPAddress;
        }

        public Byte[] Octets()
        {
            Byte[] octet = IP().GetAddressBytes();
            return octet;
        }
        public int AvailableHosts()
        {
            int cidrIndex = Array.IndexOf(submask, cidrValue);
            int totalHosts = hosts[cidrIndex] - 2;
            return totalHosts;
        }

       
        public int NetworkID()
        {
            int fourthOctet = Octets()[3];
            int resultBinary = 0;
            int cidrIndex = Array.IndexOf(submask, cidrValue);
            int cidrOctet = cidrLastOctet[cidrIndex];

            if (cidrOctet == 0)
            {
                return resultBinary;
            }

            var cidrBinary = Convert.ToString(cidrOctet, 2);
            var fourthOctetBinary = Convert.ToString((int)fourthOctet, 2);
            var result = string.Empty;
            LinkedList<char> fourthOctetList = new LinkedList<char>(fourthOctetBinary);
            LinkedList<char> cidrBinaryList = new LinkedList<char>(cidrBinary);

            var fourthLength = fourthOctetList.Count;
            var cidrLength = cidrBinaryList.Count;



            if (fourthLength < 8)
            {
                while (fourthLength < 8)
                {
                    fourthOctetList.AddFirst('0');
                    fourthLength++;
                }
            }

            if (cidrLength < 8)
            {
                while (cidrLength < 8)
                {
                    cidrBinaryList.AddFirst('0');
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (fourthOctetList.ElementAt(i) == '0' && cidrBinaryList.ElementAt(i) == '0')
                {
                    result += '0';
                }

                if (fourthOctetList.ElementAt(i) == '1' && cidrBinaryList.ElementAt(i) == '0')
                {
                    result += '0';
                }

                if (fourthOctetList.ElementAt(i) == '0' && cidrBinaryList.ElementAt(i) == '1')
                {
                    result += '0';
                }

                if (fourthOctetList.ElementAt(i) == '1' && cidrBinaryList.ElementAt(i) == '1')
                {
                    result += '1';
                }

            }

            resultBinary = int.Parse(result);
            return (Convert.ToInt32(resultBinary.ToString(), 2));
        }
        /*
        public void NumLans()
        {

            LanHostList = new List<int>();
            foreach (var t in LansValues)
            {
                LanHostList.Add( t.InitialLanValues);
            }

            for (var j = 0; j < LanHostList.Count; j++)
            {
                if (LanHostList[j] <= 8)
                {
                    LanHostList[j] += 2;
                }
            }
        }

        public void SetHosts()
        {
            for (int i = 0; i < LanHostList.Count; i++)
            {
                for (int j = 0; j < hosts.Length; j++)
                {
                    if (LanHostList[i] <= hosts[j] && LanHostList[i] >= hosts[j + 1])
                    {
                        HostsPerLan.Add(hosts[j]);
                    }
                }
            }
        }
        */
        public HtmlString  GetSubAndMask()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "../DatabaseContext/VlsmDb.db";
            var connection = new SqliteConnection(connectionStringBuilder.ConnectionString);
            connection.Open();

            LanHostList = new List<int>();
            foreach (var t in LansValues)
            {
                LanHostList.Add(t.InitialLanValues);
            }

            for (var j = 0; j < LanHostList.Count; j++)
            {
                if (LanHostList[j] <= 8)
                {
                    LanHostList[j] += 2;
                }
            }

            HostsPerLan = new List<int>();
            foreach (var t in LanHostList)
            {
                for (int j = 0; j < hosts.Length; j++)
                {
                    if (t == hosts[j])
                    {
                        HostsPerLan.Add(hosts[j]);
                    }
                    else
                    {
                        if (t < hosts[j] && t > hosts[j + 1])
                        {
                            HostsPerLan.Add(hosts[j]);
                        }
                    }
                   
                }
            }
            
            HostsPerLan.Sort();
            HostsPerLan.Reverse();
            
            var firstOctet = Octets()[0];
            var secondOctet = Octets()[1];
            var thirdOctet = Octets()[2];
            var fourthOctet = NetworkID();
            var innerTable = string.Empty; 
            FinalResult = new List<string>();

            innerTable += "<table class='table-primary table-striped caption-top'>";
            innerTable += "<thead>";
            innerTable += "<tr>";

            innerTable +=
                "<th scope='col'>Network ID</th><th scope='col'>CIDR</th><th scope='col'>Subnet Mask</th><th scope='col'>Number of Hosts per subnet</th>" +
                "<th scope='col'>LAN</th><th scope='col'>Number of subnets</th><th scope='col'>Range of usable IP addresses</th><th scope='col'>" +
                "Broadcast ID</th></tr></thead>" +
                "<tbody>";
            
            for (int i = 0; i < HostsPerLan.Count; i++)
            {
                
                string networkID = firstOctet + "." + secondOctet + "." + thirdOctet + "." + fourthOctet;
                FinalResult.Add(networkID);
               

                var subnetIndex = Array.IndexOf(hosts, HostsPerLan[i]);
                var subnetNo = subnets[subnetIndex];
                var subMaskNo = submask[subnetIndex];
                var subnetDecimal = cidrLastOctet[subnetIndex];

                string subMask = "/" + subMaskNo;
               
                FinalResult.Add(subMask);

                string subMaskNumber = "255.255.255." + subnetDecimal;
                FinalResult.Add(subMaskNumber);
                

                string hostsPerLan = Convert.ToString(HostsPerLan[i], 10);
                FinalResult.Add(hostsPerLan);
                
                string lanNumber =  "LAN: " + (i + 1);
                FinalResult.Add(lanNumber);
                
                string subnetNumber = Convert.ToString(subnetNo, 10);
                FinalResult.Add(subnetNumber);
               

                string startIpAddress = firstOctet + "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + 1) + 
                     "-" + firstOctet + "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + HostsPerLan[i] - 2);
                FinalResult.Add(startIpAddress);
                
                string broadcastID = firstOctet + "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + HostsPerLan[i] - 1);
                FinalResult.Add(broadcastID);

                innerTable += "<tr>" + "<td>" + firstOctet + "." + secondOctet + "." + thirdOctet + "." + fourthOctet + "</td>" + "<td>" + "/" +
                              subMaskNo + "</td>" + "<td>255.255.255." + subnetDecimal + "</td>" + "<td>" + HostsPerLan[i] + "</td>" + "<td>" + "LAN: " + (i + 1) + "</td>" + "<td>" + subnetNo + "</td>";

                innerTable += "<td>" + firstOctet + "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + 1) + " - " + firstOctet +
                              "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + HostsPerLan[i] - 2) + "</td>" + "<td>" + firstOctet +
                              "." + secondOctet + "." + thirdOctet + "." + (fourthOctet + HostsPerLan[i] - 1) + "</td>" + "</tr>";

                using (var transaction = connection.BeginTransaction())
                {
                    var insertCmd = connection.CreateCommand();
                    insertCmd.CommandText = "INSERT OR IGNORE INTO Vlsmresults (NetworkId, CIDR, SubnetMask, NumberOfHostsPerSubnet,  NumberOfSubnets, RangeOfUsableIpaddresses, broadcastID)" +
                                            " VALUES(" + " '" + networkID + "'," + " '" + subMask + "'," +
                                            " '" + subMaskNumber + "'," +
                                            " '" + hostsPerLan + "'," + " '" + subnetNumber + "'," + " '" + startIpAddress +
                                            "'," + " '" + broadcastID + "')";
                    insertCmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                fourthOctet += HostsPerLan[i];
            }
            innerTable += "</tbody></table>";
            connection.Close();
            return new HtmlString(innerTable);
        }
    }
}
