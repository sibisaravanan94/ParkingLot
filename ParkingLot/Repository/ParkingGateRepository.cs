using ParkingLot.Models;

namespace ParkingLot.Repository
{
    public class ParkingGateRepository : IParkingGateRepository
    {
        List<ParkingGate> _parkingGates = new List<ParkingGate>();
        public List<ParkingGate> save(int NumberOfEntryGates, GateType type)
        {
            for(int i=0; i<NumberOfEntryGates; i++)
            {
                ParkingGate gate = new ParkingGate();
                gate.Type = type;
                gate.Status = GateStatus.Free;
                _parkingGates.Add(gate);
            }
            return _parkingGates;
        }
    }
}
