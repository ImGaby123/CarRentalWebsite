using CarRentalWebsite.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dashboard d = new();
            return View(d);
        }

        [HttpPost]

        public IActionResult Index(Models.Dashboard d) {

            return View();
        }
    }
}
