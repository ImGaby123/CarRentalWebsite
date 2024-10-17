namespace CarRentalWebsite.Areas.Admin.Models
{
    public class Transactions
    {

        // Total Earnings Data Summary 
        public double total_Earnings { get; set; }
        public double total_AmountPaid { get; set; }
        public double total_Refunds { get; set; }

        public Transactions()
        {
            total_Earnings = 1000000;
            total_AmountPaid = 50000;
            total_Refunds = 30000;
        }
    }
}
