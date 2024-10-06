using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class FleetController : Controller
    {
        public IActionResult Fleet()
        {
            return View();
        }
    }
}
