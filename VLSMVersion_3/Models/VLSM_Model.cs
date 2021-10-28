using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
        
        
        public VLSM_Model()
        {
            LansValues = new List<Lans>();
            
        }

        public VLSM_Model(List<Lans> lansValues)
        {
            LansValues = lansValues;
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

        public void NumLans()
        {

            LanHostList = new List<int>();
            for (int i = 0; i < LansValues.Count; i++)
            {
                LanHostList[i] = LansValues[i].InitialLanValues;
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

        public List<string> getSubAndMask()
        {
            LanHostList = new List<int>();
            for (int i = 0; i < LansValues.Count; i++)
            {
                LanHostList.Add(LansValues[i].InitialLanValues);
            }

            for (var j = 0; j < LanHostList.Count; j++)
            {
                if (LanHostList[j] <= 8)
                {
                    LanHostList[j] += 2;
                }
            }

            HostsPerLan = new List<int>();
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
            HostsPerLan.Sort();
            HostsPerLan.Reverse();

            var firstOctet = Octets()[0];
            var secondOctet = Octets()[1];
            var thirdOctet = Octets()[3];
            var fourthOctet = NetworkID();
            FinalResult = new List<string>();

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
                     "-" + firstOctet + "." + secondOctet + "." + thirdOctet + "." + (firstOctet + HostsPerLan[i] - 2);
                FinalResult.Add(startIpAddress);
                
                string broadcastID = firstOctet + "." + secondOctet + "." + thirdOctet + "." + (firstOctet + HostsPerLan[i] - 1);
                FinalResult.Add(broadcastID);

                fourthOctet += HostsPerLan[i];
            }
            return FinalResult;
        }
    }
}
