namespace ParkingLot.Models
{
    public class Bill : BaseModel
    {
        public string BillID { get; set; }
        public Ticket Ticket { get; set; }
        public double Amount { get; set; }
        public List<Payment> Payments { get; set; } = new List<Payment>();
        public ParkingGate ExitGate { get; set; }
        public ParkingOperator Operator { get; set; }
        public DateTime ExitTime { get; set; }
    }
}