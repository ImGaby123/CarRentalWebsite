using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("About")]
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
