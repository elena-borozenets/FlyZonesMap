using System.Data.Entity;
using FlyZonesMap.Data.Entities;

namespace FlyZonesMap.Infrastructure.Context
{
    public class FlyZonesMapDbContext : DbContext
    {
        public FlyZonesMapDbContext() : base("FlyZonesMapDbContext")
        {

        }

        public DbSet<Place> Places { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Viewport> Viewports { get; set; }
    }
}
