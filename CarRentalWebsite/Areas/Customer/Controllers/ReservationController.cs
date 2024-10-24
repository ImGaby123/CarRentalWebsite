using Microsoft.AspNetCore.Mvc;
using CarRentalWebsite.Areas.Customer.Models;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ReservationController : Controller
    {
        // Existing method to display the reservation form
        public IActionResult Reserve(int id, string carmodel, string image, string transmission, string formattedcarprice, decimal price, int door, int seat, string category, string topFeature, string safety)
        {
            ViewBag.CarId = id;
            ViewBag.CarModel = carmodel;
            ViewBag.CarImage = image;
            ViewBag.CarTransmission = transmission;
            ViewBag.FormattedCarPrice = formattedcarprice;
            ViewBag.CarPrice = price;
            ViewBag.CarDoor = door;
            ViewBag.CarSeat = seat;
            ViewBag.CarCategory = category;
            ViewBag.CarTopFeature = topFeature;
            ViewBag.CarSafety = safety;

            return View();
        }

        // New action method to handle form submission
        [HttpPost]
        public IActionResult Submit(ReservationModel model)
        {
            if (ModelState.IsValid)
            {
                // Handle reservation logic here
                // For example, save the reservation to a database

                // Redirect to a confirmation page
                return RedirectToAction("Confirmation");
            }

            // If validation fails, redisplay the form with validation messages
            return View("Reserve", model);
        }

        // Existing method for confirmation
        public IActionResult Confirmation()
        {
            return View();
        }
    }
}