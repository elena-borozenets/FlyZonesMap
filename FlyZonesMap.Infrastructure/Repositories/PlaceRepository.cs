using System.Collections.Generic;
using System.Linq;
using FlyZonesMap.Data.Entities;
using FlyZonesMap.Infrastructure.DbContext;

namespace FlyZonesMap.Infrastructure.Repositories
{
    public class PlaceRepository: IPlaceRepository
    {
        public List<Place> GetPlaces()
        {
            using (var db = new FlyZonesMapDbContext())
            {
                var places = (from place in db.Places select place).ToList();
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