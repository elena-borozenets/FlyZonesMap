using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyZonesMap.Models
{
    public class LocationModel
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class LocationModelList
    {
        public LocationModelList()
        {
            Locations = new List<LocationModel>();
        }
        public List<LocationModel> Locations { get; set; }
    }
}