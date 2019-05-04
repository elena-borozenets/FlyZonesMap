using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FlyZonesMap.Data.Entities;
using FlyZonesMap.Infrastructure.Context;

namespace FlyZonesMap.Infrastructure.Repositories
{
    public class PlaceRepository: IPlaceRepository
    {
        public List<Place> GetPlaces()
        {
            using (var db = new FlyZonesMapDbContext())
            {
                var places = db.Places
                    .Include(pl => pl.Location)
                    .Include(pl => pl.Viewport)
                    .Include(pl=>pl.Viewport.NortheastLocation)
                    .Include(pl=>pl.Viewport.SouthwestLocation)
                    .ToList();
                return places;
            }
        }

        public void SavePlaces(List<Place> places)
        {
            using (var db = new FlyZonesMapDbContext())
            {
                db.Places.AddRange(places);
                db.SaveChanges();
            }
        }
    }
}