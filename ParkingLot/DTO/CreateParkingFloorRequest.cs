using ParkingLot.Models;

namespace ParkingLot.DTO
{
    public class CreateParkingFloorRequest
    {
        public int NumberOfSmallSpots { get; set; }
        public int NumberOfMediumSpots { get; set; }
        public int NumberOfLargeSpots { get; set; }

        internal ParkingFloor transformToParkingFloor(CreateParkingFloorRequest floorRequest)
        {
            throw new NotImplementedException();
        }
    }
}
