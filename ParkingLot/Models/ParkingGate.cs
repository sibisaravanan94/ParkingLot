namespace ParkingLot.Models
{
    public class ParkingGate : BaseModel
    {
        public int GateNumber { get; set; }
        public ParkingOperator Operator { get; set; }
        public GateStatus Status { get; set; }
        public GateType Type { get; set; }
    }
}
