namespace FlyZonesMap.Models
{
    public class Viewport
    {
        public int Id { get; set; }
        public Location NortheastLocation { get; set; }
        public Location SouthwestLocation { get; set; }
    }
}