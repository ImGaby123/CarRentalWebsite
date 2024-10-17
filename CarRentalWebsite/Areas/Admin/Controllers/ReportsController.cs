using CarRentalWebsite.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReportsController : Controller
    {
        public IActionResult Reports()
        {
            Transactions t = new();
            return View(t);
        }
    }
}
