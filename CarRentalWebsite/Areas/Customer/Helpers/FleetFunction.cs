using CarRentalWebsite.Areas.Customer.Models;

namespace CarRentalWebsite.Areas.Customer.Helpers
{
    public class FleetFunction
    {
        public static List<Fleet> GetFleetData()
        {
            var fleetList = new List<Fleet>();

            var car1 = new Fleet
            {
                CarModel = "TOYOTA PICK-UP TRUCKS",
                CarCategory = "Pick-Up Trucks",
                CarPrice = 4400.00,
                CarTransmission = "A/M Transmission",
                CarSeat = 5,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "Advanced safety technologies, including Toyota Safety Sense (pre-collision system, lane departure alert)",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_d.png"
            };

            var car2 = new Fleet
            {
                CarModel = "TOYOTA PICK-UP TRUCKS",
                CarCategory = "Pick-Up Trucks",
                CarPrice = 4400.00,
                CarTransmission = "A/M Transmission",
                CarSeat = 6,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "Advanced safety technologies, including Toyota Safety Sense (pre-collision system, lane departure alert)",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_e.png"
            };

            var car3 = new Fleet
            {
                CarModel = "TOYOTA PICK-UP TRUCKS",
                CarCategory = "Pick-Up Trucks",
                CarPrice = 4400.00,
                CarTransmission = "A/M Transmission",
                CarSeat = 4,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "Advanced safety technologies, including Toyota Safety Sense (pre-collision system, lane departure alert)",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\r\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_b.png"
            };

            var car4 = new Fleet
            {
                CarModel = "TOYOTA PICK-UP TRUCKS",
                CarCategory = "Pick-Up Trucks",
                CarPrice = 4400.00,
                CarTransmission = "A/M Transmission",
                CarSeat = 4,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "Advanced safety technologies, including Toyota Safety Sense (pre-collision system, lane departure alert)",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\r\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_c.png"
            };

            var car5 = new Fleet
            {
                CarModel = "TOYOTA PICK-UP TRUCKS",
                CarCategory = "Pick-Up Trucks",
                CarPrice = 4400.00,
                CarTransmission = "A/M Transmission",
                CarSeat = 5,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "Advanced safety technologies, including Toyota Safety Sense (pre-collision system, lane departure alert)",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\r\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_a.png"
            };

            fleetList.Add(car1);
            fleetList.Add(car2);
            fleetList.Add(car3);
            fleetList.Add(car4);
            fleetList.Add(car5);

            return fleetList;
        }
    }
}
