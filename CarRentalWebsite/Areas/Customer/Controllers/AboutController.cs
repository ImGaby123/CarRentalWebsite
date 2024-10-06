using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
