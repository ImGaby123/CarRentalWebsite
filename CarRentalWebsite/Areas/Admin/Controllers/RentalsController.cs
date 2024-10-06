using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RentalsController : Controller
    {
        public IActionResult Rentals()
        {
            return View();
        }
    }
}
