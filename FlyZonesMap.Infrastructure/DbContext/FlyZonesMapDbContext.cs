using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using FlyZonesMap.Data.Entities;

namespace FlyZonesMap.Infrastructure.DbContext
{
    public class FlyZonesMapDbContext : System.Data.Entity.DbContext
    {
        public FlyZonesMapDbContext() : base("FlyZonesMapDbContext")
        {

        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Viewport> Viewports { get; set; }
    }
}
