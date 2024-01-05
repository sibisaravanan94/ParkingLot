namespace ParkingLot.Models
{
    public class Vehicle : BaseModel
    {
        public string VehichleID { get; set; }
        public string RegistrationID { get; set; }
        public VehicleType VehicleType { get; set; }
    }
}