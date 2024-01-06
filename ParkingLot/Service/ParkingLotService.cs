using ParkingLot.DTO;
using ParkingLot.Models;
using ParkingLot.Repository;

namespace ParkingLot.Service
{
    public class ParkingLotService
    {
        private IParkingLotRepository _parkingLotRepository;
        private ParkingGateService _parkingGateService;
        public ParkingLotService(IParkingLotRepository parkingLotRepository, ParkingGateService parkingGateService)
        {
            _parkingLotRepository = parkingLotRepository;
            _parkingGateService = parkingGateService;
        }
        internal ParkingLotModel createParkingLot(CreateParkingLotRequest createParkingLotRequest)
        {
            ParkingFloorService parkingFloorService = new ParkingFloorService();

            List<ParkingFloor> parkingFloors = parkingFloorService.CreateParkingFloor(createParkingLotRequest.floors);
            List<ParkingGate> EntryGates = _parkingGateService.CreateParkingGates(createParkingLotRequest.NumberOfEntryGates, GateType.Entry);
            List<ParkingGate> ExitGates = _parkingGateService.CreateParkingGates(createParkingLotRequest.NumberOfEntryGates, GateType.Exit);
            
            ParkingLotModel parkingLotModel = new ParkingLotModel();
            parkingLotModel.Name = createParkingLotRequest.Name;
            parkingLotModel.Adress = createParkingLotRequest.Address;
            parkingLotModel.ParkingFloors = parkingFloors;
            parkingLotModel.EntryGates = EntryGates;
            parkingLotModel.ExitGates = ExitGates;
            
            return _parkingLotRepository.save(parkingLotModel);
        }
    }
}
