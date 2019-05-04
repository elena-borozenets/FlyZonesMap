using System.Collections.Generic;
using FlyZonesMap.Models;

namespace FlyZonesMap.Service
{
    public interface IPlaceService
    {
        string GetRequest(string url);
        List<Place> DeserializeData(string json);
        void SavePlaces(List<Place> places);
        List<Place> GetPlaces();
    }
}