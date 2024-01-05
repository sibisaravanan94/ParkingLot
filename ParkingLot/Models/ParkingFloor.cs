namespace ParkingLot.Models
{
    public class ParkingFloor : BaseModel
    {
        public int FloorNumber { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();
        public PaymentCounter Counter { get; set; }
        public DisplayBoard DisplayBoard { get; set; }
    }
}