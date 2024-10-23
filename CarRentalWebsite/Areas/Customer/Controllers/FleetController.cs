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
        public IActionResult Reservation()
        {

            return View();
        }
    }
}
