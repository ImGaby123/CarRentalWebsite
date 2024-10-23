using Microsoft.AspNetCore.Mvc;
using CarRentalWebsite.Areas.Customer.Helpers;


namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class FleetController : Controller
    {
        public IActionResult Fleet()
        {
            var fleetList = FleetFunction.GetFleetData();

            return View(fleetList);
        }
        public IActionResult BookNow(int carId)
        {
            var fleet = FleetFunction.GetFleetData();

            var car = fleet.FirstOrDefault(c => c.CarId == carId);

            if (car == null)
            {
                return NotFound();
            }

            return RedirectToAction("Reserve", "Reservation", new
            {
                id = car.CarId,
                model = car.CarModel,
                image = car.CarImage,
                transmission = car.CarTransmission,
                formattedcarprice = car.FormattedCarPrice,
                price = car.CarPrice,
                door = car.CarDoor,
                seat = car.CarSeat,
                category = car.CarCategory,
                topFeature = car.CarTopFeature,
                safety = car.CarSafety
            });
        }
    }
}
