using Microsoft.AspNetCore.Mvc;
using CarRentalWebsite.Areas.Customer.Models;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ReservationController : Controller
    {
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