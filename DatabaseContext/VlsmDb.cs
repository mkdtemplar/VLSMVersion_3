using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class VlsmDb : DbContext
    {
        public VlsmDb(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<Vlsmresult> Vlsmresults { get; set; }
    }
}
