using CarRentalWebsite.Areas.Customer.Models;
using System.Globalization;

namespace CarRentalWebsite.Areas.Customer.Helpers
{
    public class FleetFunction
    {
        public static List<Fleet> GetFleetData()
        {
            var fleetList = new List<Fleet>();

            var car1 = new Fleet
            {
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

            var car2 = new Fleet
            {
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

            var car3 = new Fleet
            {
                CarModel = "Mitsubishi Mirage 2024",
                CarCategory = "Sedan",
                CarPrice = 2800.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 5,
                CarDoor = 5,
                CarBaggage = 3,
                CarTopFeature = "Keyless Entry, Apple CarPlay/Android Auto, Bluetooth Audio",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/mitsubishi_mirage_2024.png"
            };

            var car4 = new Fleet
            {
                CarModel = "Honda Brio 2024",
                CarCategory = "Sedan",
                CarPrice = 3000.00m,
                CarTransmission = "Automatic/Manual Transimision",
                CarSeat = 5,
                CarDoor = 5,
                CarBaggage = 3,
                CarTopFeature = "7-inch Touchscreen Display, Keyless Entry, LED Headlights",
                CarSafety = "Toyota Safety Sense (pre-collision system, Lane departure alert, Adaptive cruise control) Vehicle Stability Control Anti-lock Braking System (ABS) with Electronic Brakeforce Distribution (EBD)",
                CarImage = "~/Customer/img/hatchback.png"
            };

            var car5 = new Fleet
            {
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

            fleetList.Add(car1);
            fleetList.Add(car2);
            fleetList.Add(car3);
            fleetList.Add(car4);
            fleetList.Add(car5);

            return fleetList;
        }
    }
}
