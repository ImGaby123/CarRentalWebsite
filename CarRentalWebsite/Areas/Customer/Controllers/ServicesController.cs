using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}
