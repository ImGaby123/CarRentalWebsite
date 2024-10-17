using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class Reservation
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Pick-up location is required")]
        public string PickupLocation { get; set; }

        [Required(ErrorMessage = "Return location is required")]
        public string ReturnLocation { get; set; }

        [Required(ErrorMessage = "From date is required")]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "From time is required")]
        [DataType(DataType.Time)]
        public DateTime FromTime { get; set; }

        [Required(ErrorMessage = "Until date is required")]
        [DataType(DataType.Date)]
        public DateTime UntilDate { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Until time is required")]
        [DataType(DataType.Time)]
        public DateTime UntilTime { get; set; }
    }
}