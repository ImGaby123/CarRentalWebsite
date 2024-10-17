using Microsoft.AspNetCore.Mvc;

namespace CarRentalWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Models.Dashboard d) {

            double totalRevenue = 500000;
            double totalACustomer = 10500;
            double totalRentedCars = 5600;


            // Model Var assignment Here
            d.total_Revenue = totalRevenue;
            d.total_ACustomer = totalACustomer;
            d.total_RentedCars = totalRentedCars;

            return View(d);
        }
    }
}
