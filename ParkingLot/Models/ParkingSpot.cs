namespace ParkingLot.Models
{
    public class ParkingSpot
    {
        public int SpotNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public SpotStatus SpotStatus { get; set; }
    }
}