using ParkingLot.Models;

namespace ParkingLot.Repository
{
    public interface IParkingLotRepository
    {
        public ParkingLotModel save(ParkingLotModel parkingLotModel);
    }
}
