using ParkingLot.Models;
using ParkingLot.Repository;

namespace ParkingLot.Service
{
    public class ParkingGateService
    {
        private IParkingGateRepository _parkingGateRepository;
        public ParkingGateService(IParkingGateRepository parkingGateRepository)
        {
            _parkingGateRepository = parkingGateRepository;
        }
        public ParkingGateService()
        {

        }
        internal List<ParkingGate> CreateParkingGates(int numberOfEntryGates, GateType entry)
        {
            return _parkingGateRepository.save(numberOfEntryGates, entry);
        }
    }
}
