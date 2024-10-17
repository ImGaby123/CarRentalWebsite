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

            double totalRevenue = 500000.00;
            double totalACustomer = 10500.00;
            double totalRentedCars = 5600.00;


            // Model Var assignment Here
            d.Total_Revenue = totalRevenue;
            d.Total_ACustomer = totalACustomer;
            d.total_RentedCars = totalRentedCars;

            return View(d);
        }
    }
}
