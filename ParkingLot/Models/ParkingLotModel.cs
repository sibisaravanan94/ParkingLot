namespace ParkingLot.Models
{
    public class ParkingLotModel : BaseModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<ParkingFloor> ParkingFloors { get; set; } = new List<ParkingFloor>();
        public List<ParkingGate> EntryGates { get; set; } = new List<ParkingGate>();
        public List<ParkingGate> ExitGates { get; set; } = new List<ParkingGate>();
        
    }
}
