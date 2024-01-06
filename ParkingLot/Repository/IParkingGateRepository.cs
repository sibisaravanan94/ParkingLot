using ParkingLot.Models;

namespace ParkingLot.Repository
{
    public interface IParkingGateRepository
    {
        public List<ParkingGate> save(int NumberOfEntryGates, GateType type);
    }
}
