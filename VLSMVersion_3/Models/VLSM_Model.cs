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
        public List<Lans> FinalNumberOfHosts { get; set; }
        public List<Lans> InitialValuesOfLan { get; set; }

        public int NumberOfHosts { get; set; }
        
        public VLSM_Model()
        {
            LansValues = new List<Lans>();
        }

        public int[] subnets = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };
        public int[] hosts = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };
        public int[] submask = { 24, 25, 26, 27, 28, 29, 30, 31, 32 };
        public int[] cidrLastOctet = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

        public List<Lans> LanHostList { get; set; }
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


            for (int i = 0; i < LansValues.Count; i++)
            {
                LanHostList[i] = LansValues[i];
            }

            for (var j = 0; j < LanHostList.Count; j++)
            {
                if (LanHostList[j].InitialLanValues <= 8)
                {
                    LanHostList[j].InitialLanValues += 2;
                }
            }
        }

        public void SetHosts()
        {
            for (int i = 0; i < LanHostList.Count; i++)
            {
                for (int j = 0; j < hosts.Length; j++)
                {
                    if (LanHostList[i].InitialLanValues <= hosts[j] && LanHostList[i].InitialLanValues >= hosts[j + 1])
                    {
                        HostsPerLan[i] = hosts[j];
                    }
                }
            }
        }

       
    }
}
