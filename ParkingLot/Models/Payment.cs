namespace ParkingLot.Models
{
    public class Payment : BaseModel
    {
        public string PaymentID { get; set; }
        public double Amount { get; set; }
        public PaymentType Type { get; set; }
        public PaymentStatus Status { get; set; }
        public string ReferenceID { get; set; }
        public DateTime PaymentTime { get; set; }
        public Bill Bill { get; set; }
    }
}
