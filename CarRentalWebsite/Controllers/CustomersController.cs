using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
