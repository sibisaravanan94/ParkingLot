namespace ParkingLot.Models
{
    public class Ticket : BaseModel
    {
        public string TickerID { get; set; }
        public ParkingSpot Spot { get; set; }
        public Vehicle vehicle { get; set; }
        public ParkingGate EntryGate { get; set; }
        public ParkingOperator Operator { get; set; }
        public DateTime EntryTime { get; set; }
    }
}
