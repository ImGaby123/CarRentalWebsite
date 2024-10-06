using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarsController : Controller
    {
        public IActionResult Cars()
        {
            return View();
        }
    }
}
