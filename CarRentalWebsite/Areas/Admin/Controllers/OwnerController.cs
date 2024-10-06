using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OwnerController : Controller
    {
        public IActionResult Owner()
        {
            return View();
        }
    }
}
