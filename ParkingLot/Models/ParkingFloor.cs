namespace ParkingLot.Models
{
    public class ParkingFloor : BaseModel
    {
        public int FloorNumber { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();
    }
}