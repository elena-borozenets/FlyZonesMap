using AutoMapper;

namespace FlyZonesMap.Service
{
    using PlaceDbo = FlyZonesMap.Data.Entities;
    using PlaceModel = FlyZonesMap.Models;
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PlaceDbo.Place, PlaceModel.Place>();
            CreateMap<PlaceModel.Place, PlaceDbo.Place>();
            CreateMap<PlaceDbo.Location, PlaceModel.Location>();
            CreateMap<PlaceModel.Location, PlaceDbo.Location>();
            CreateMap<PlaceDbo.Viewport, PlaceModel.Viewport>();
            CreateMap<PlaceModel.Viewport, PlaceDbo.Viewport>();
        }


    }
}
