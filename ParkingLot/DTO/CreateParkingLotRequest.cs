using ParkingLot.Models;

namespace ParkingLot.DTO
{
    public class CreateParkingLotRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<CreateParkingFloorRequest> floors { get; set; }
        public int NumberOfEntryGates { get; set; }
        public int NumberOfExitGates { get; set; }

        public Models.ParkingLotModel transformToParkingLot()
        {
            CreateParkingFloorRequest floorRequest = new CreateParkingFloorRequest();
            ParkingFloor parkingFloor = floorRequest.transformToParkingFloor(floorRequest);
            return new ParkingLotModel();
        }
    }
}
