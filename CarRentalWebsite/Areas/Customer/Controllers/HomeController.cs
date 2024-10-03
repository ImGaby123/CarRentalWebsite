using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
