namespace ParkingLot.Models
{
    public class ParkingSpot : BaseModel
    {
        public int SpotNumber { get; set; }
        public VehicleType VehicleType { get; set; }
        public SpotStatus SpotStatus { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}