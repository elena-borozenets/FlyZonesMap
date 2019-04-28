namespace FlyZonesMap.Models
{
    public class Place
    {
        public string Id { get; set; }
        public string FormattedAddress { get; set; }
        public int LocationId { get; set; }
        public int ViewportId { get; set; }
        public string Name { get; set; }
        public string PlaceId { get; set; }
        public string Reference { get; set; }
        public string Type { get; set; }
    }
}