using Microsoft.AspNetCore.Mvc;
using CarRentalWebsite.Areas.Customer.Helpers;
using CarRentalWebsite.Areas.Customer.Models;
using System.Collections.Generic;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class Fleet
    {
        public string CarModel { get; set; }
        public string CarTransmission { get; set; }
        public int CarDoor { get; set; }
        public int CarSeat { get; set; }
        public int CarBaggage { get; set; }
        public string CarCategory { get; set; }
        public double CarPrice { get; set; }
        public string CarTopFeature { get; set; }
        public string CarSafety { get; set; }
        public string CarImage { get; set; }
    }
}
