using Microsoft.AspNetCore.Mvc;
using ParkingLot.DTO;
using ParkingLot.Models;

namespace ParkingLot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParkingLotController : ControllerBase
    {
        [HttpPost]
        public IActionResult createParkingLot(CreateParkingLotRequest createParkingLotRequest)
        {
            // Validate incoming request
            if (!validateCreateParkingLotRequest(createParkingLotRequest))
            {
                return BadRequest();
            }
            ParkingLotModel parkingLot = createParkingLotRequest.transformToParkingLot();
            // If possible convet the dto to model

            return Accepted();
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

        private bool validateCreateParkingLotRequest(CreateParkingLotRequest createParkingLotRequest)
        {
            if (createParkingLotRequest.floors.Count() < 0)
            {
                return false;
            }
            if(createParkingLotRequest.floors.Where(floor => floor.NumberOfLargeSpots<0 
                || floor.NumberOfMediumSpots<0 
                || floor.NumberOfSmallSpots < 0).Count() > 0)
            {
                return false;
            }
            return true;
        }
    }
}
