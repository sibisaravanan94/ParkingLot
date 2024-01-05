using ParkingLot.Models;

namespace ParkingLot.DTO
{
    public class CreateParkingLotRequest
    {
        public string Name { get; set; }
        public List<CreateParkingFloorRequest> floors { get; set; }
        public int NumberOfEntryGates { get; set; }
        public int NumberOfExitGates { get; set; }

        public Models.ParkingLotModel transformToParkingLot()
        {
            return new ParkingLotModel();
        }
    }
}
