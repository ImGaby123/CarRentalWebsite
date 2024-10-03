using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customers.Controllers
{
    [Area("Customers")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
