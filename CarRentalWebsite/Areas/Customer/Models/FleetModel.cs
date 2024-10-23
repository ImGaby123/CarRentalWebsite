using System.Globalization;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class FleetModel
    {
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string CarTransmission { get; set; }
        public int CarDoor { get; set; }
        public int CarSeat { get; set; }
        public int CarBaggage { get; set; }
        public string CarCategory { get; set; }
        public decimal CarPrice { get; set; }
        public string FormattedCarPrice => CarPrice.ToString("C2", new CultureInfo("en-PH"));
        public string CarTopFeature { get; set; }
        public string CarSafety { get; set; }
        public string CarImage { get; set; }
    }
}
