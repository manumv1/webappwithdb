using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace myfirstasp.Models
{
    public class myfirstaspContext : DbContext
    {
        public myfirstaspContext (DbContextOptions<myfirstaspContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<myfirstasp.Models.employee> Employee { get; set; }
    }
}
