namespace ParkingLot.Models
{
    public class ParkingLot : BaseModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<ParkingFloor> ParkingFloors { get; set; } = new List<ParkingFloor>();
        public List<EntryGate> EntryGates { get; set; } = new List<EntryGate>();
        public List<ExitGate> ExitGates { get; set; } = new List<ExitGate>();
    }
}
