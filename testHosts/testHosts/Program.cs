using System;
using System.Collections.Generic;
using static System.Console;

namespace testHosts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> HostsPerLan = new List<int>();
            List<int> LanHostList = new List<int>() { 32 };
            
         int[] subnets = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };
         int[] hosts = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };
         int[] submask = { 24, 25, 26, 27, 28, 29, 30, 31, 32 };
         int[] cidrLastOctet = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

         for (var i = 0; i < LanHostList.Count; i++)
         {
             var t = LanHostList[i];
             for (int j = 0; j < hosts.Length - 1; j++)
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

         for (int i = 0; i < HostsPerLan.Count; i++)
         {
             var subnetIndex = Array.IndexOf(hosts, HostsPerLan[i]);
             var subnetNo = subnets[subnetIndex];
             var subMaskNo = submask[subnetIndex];
             var subnetDecimal = cidrLastOctet[subnetIndex];
             WriteLine($"Host per lan: {HostsPerLan[i]}");
             WriteLine(subnetIndex );
         }
         
        }
    }
}