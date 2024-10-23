using Microsoft.AspNetCore.Mvc;
using CarRentalWebsite.Areas.Customer.Helpers;
using CarRentalWebsite.Areas.Customer.Models;


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
            return RedirectToAction("Reserve", "Reservation", new { id = carId });
        }
    }
}
