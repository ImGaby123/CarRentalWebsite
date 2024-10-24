using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")] 
    public class ReservationController : Controller
    {
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
    }
}