namespace CarRentalWebsite.Areas.Admin.Models
{
    public class Dashboard
    {

        // Dashboard Totals Data Summary 
        public double total_Revenue { get; set; }
        public double total_ACustomer { get; set; }
        public double total_RentedCars { get; set; }

        public Dashboard() {
            total_Revenue = 500000;
            total_ACustomer = 10500;
            total_RentedCars = 5600;
        }
    }
}
