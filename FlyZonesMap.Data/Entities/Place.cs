namespace FlyZonesMap.Data.Entities
{
    public class Place
    {
        public string Id { get; set; }
        public string FormattedAddress { get; set; }
        public Location Location { get; set; }
        public Viewport Viewport { get; set; }
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
    }
}