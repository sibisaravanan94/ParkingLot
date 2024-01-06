using ParkingLot.Models;

namespace ParkingLot.Repository
{
    public class ParkingLotRepository : IParkingLotRepository
    {
        private List<ParkingLotModel> _parkingLots = new List<ParkingLotModel>();
        public ParkingLotModel save(ParkingLotModel parkingLotModel)
        {
            _parkingLots.Add(parkingLotModel);
            return parkingLotModel;
        }
    }
}
