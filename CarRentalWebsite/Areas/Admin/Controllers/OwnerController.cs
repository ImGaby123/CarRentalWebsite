using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    public class OwnerController : Controller
    {
        public IActionResult Owner()
        {
            return View();
        }
    }
}
