using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DatabaseContext
{
    public class Vlsmresult
    {
        
        [Column("id")]
        [Key]
        public long Id { get; set; }

        [Column("NetworkID", TypeName = "VARCHAR (45)")]
        public string NetworkId { get; set; }

        [Column("CIDR", TypeName = "VARCHAR (45)")]
        public string Cidr { get; set; }

        [Column(TypeName = "VARCHAR (45)")]
        public string SubnetMask { get; set; }

        [Column(TypeName = "VARCHAR (45)")]
        public string NumberOfHostsPerSubnet { get; set; }

        [Column(TypeName = "VARCHAR (45)")]
        public string NumberOfSubnets { get; set; }

        [Column("RangeOfUsableIPaddresses", TypeName = "VARCHAR (45)")]
        public string RangeOfUsableIpaddresses { get; set; }

        [Column("broadcastID", TypeName = "VARCHAR (45)")]
        public string BroadcastId { get; set; }
    }
}
