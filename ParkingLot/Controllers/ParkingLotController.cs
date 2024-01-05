using Microsoft.AspNetCore.Mvc;

namespace ParkingLot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingLotController : ControllerBase
    {
        [HttpPost]
        public void createParkingLot()
        {

        }
        [HttpGet]
        public void getAllParkingLot()
        {

        }
        [HttpGet("{lotID}")]
        public void getAllParkingLotById(int lotID)
        {

        }
        [HttpPut]
        public void updateParkingLot()
        {

        }
        [HttpDelete]
        public void deleteParkingLot()
        {

        }
    }
}
