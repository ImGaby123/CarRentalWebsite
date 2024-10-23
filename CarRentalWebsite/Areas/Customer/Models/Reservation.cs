using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class Reservation
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string PhoneNumber { get; set; }

        public required string PickupLocation { get; set; }

        public required string ReturnLocation { get; set; }

        [DataType(DataType.Date)]
        public required DateTime FromDate { get; set; } = DateTime.Today;
      
        [DataType(DataType.Time)]
        public required DateTime FromTime { get; set; }

        [DataType(DataType.Date)]
        public required DateTime UntilDate { get; set; } = DateTime.Today;

        [DataType(DataType.Time)]
        public required DateTime UntilTime { get; set; }
    }
}