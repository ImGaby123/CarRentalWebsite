using CarRentalWebsite.Areas.Customer.Models;
using System.Globalization;

namespace CarRentalWebsite.Areas.Customer.Helpers
{
    public class FleetFunction
    {
        public static List<FleetModel> GetFleetData()
        {
            var fleetList = new List<FleetModel>();

            var car1 = new FleetModel
            {
                CarId = 1,
                CarModel = "Honda Brio 2024",
                CarCategory = "Sedan",
                CarPrice = 3000.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 5,
                CarDoor = 5,
                CarBaggage = 3,
                CarTopFeature = "7-inch Touchscreen Display, Keyless Entry, LED Headlights",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/honda_brio_2024.png"
            };

            var car2 = new FleetModel
            {
                CarId = 2,
                CarModel = "Honda City 2024",
                CarCategory = "Sedan",
                CarPrice = 3500.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 6,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "8-inch Infotainment System, Push Start, Leather Upholstery",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/honda_city_2024.png"
            };

            var car3 = new FleetModel
            {
                CarId = 3,
                CarModel = "Mitsubishi Mirage 2024",
                CarCategory = "Sedan",
                CarPrice = 2800.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 5,
                CarDoor = 5,
                CarBaggage = 3,
                CarTopFeature = "Keyless Entry, Apple CarPlay/Android Auto, Bluetooth Audio",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/mitsubishi_mirage_20241.png"
            };

            var car4 = new FleetModel
            {
                CarId = 4,
                CarModel = "Honda Brio 2024",
                CarCategory = "Sedan",
                CarPrice = 3000.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 5,
                CarDoor = 5,
                CarBaggage = 3,
                CarTopFeature = "7-inch Touchscreen Display, Keyless Entry, LED Headlights",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/home_hatchback.png"
            };

            var car5 = new FleetModel
            {
                CarId = 5,
                CarModel = "Honda City 2024",
                CarCategory = "Sedan",
                CarPrice = 3500.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 6,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "8-inch Infotainment System, Push Start, Leather Upholstery",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/img_b.png"
            };

            var car6 = new FleetModel
            {
                CarId = 6,
                CarModel = "Suzuki Celerio",
                CarCategory = "Sedan",
                CarPrice = 2800.00m,
                CarTransmission = "Automatic/CVT Transimision",
                CarSeat = 6,
                CarDoor = 4,
                CarBaggage = 3,
                CarTopFeature = "7-inch Touchscreen, Auto Gear Shift, Spacious Cabin",
                CarSafety = "Toyota Safety Sense (pre-collision system, lane departure alert, adaptive cruise control)\nVehicle Stability Control\r\nAnti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/suzuki_celerio.png"
            };

            fleetList.Add(car1);
            fleetList.Add(car2);
            fleetList.Add(car3);
            fleetList.Add(car4);
            fleetList.Add(car5);
            fleetList.Add(car6);

            return fleetList;
        }
    }
}
