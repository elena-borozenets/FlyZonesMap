using System.Collections.Generic;
using FlyZonesMap.Data.Entities;

namespace FlyZonesMap.Infrastructure.Repositories
{
    public interface IPlaceRepository
    {
        List<Place> GetPlaces();
        void SavePlaces(List<Place> places);
    }
}