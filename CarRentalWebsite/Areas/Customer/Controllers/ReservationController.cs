using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")] 
    public class ReservationController : Controller
    {
        public IActionResult Reserve(int id)
        {
            ViewBag.CarId = id; 
            return View();
        }
    }
}