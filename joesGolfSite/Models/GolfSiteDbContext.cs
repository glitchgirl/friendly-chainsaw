using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace joesGolfSite.Models
{
    public class GolfSiteDbContext : DbContext
    {
        public GolfSiteDbContext() : base("GolfSiteDbContext")
        {
        }
        public DbSet<Registerer> Registerers { get; set; }
    }
}