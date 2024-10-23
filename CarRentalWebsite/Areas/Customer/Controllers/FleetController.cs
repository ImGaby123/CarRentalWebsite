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

        [HttpGet]
        public IActionResult Reservation()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitReservation(Reservation model)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Success");
            }


            return View("Reservation", model);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
