using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class ReservationModel
    {
       [Required]
        public int ReservationId { get; set; }
        [Required]
        public int CarId { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]

        public required string Email { get; set; }
        [Required]

        public required string PhoneNumber { get; set; }
        [Required]
        public required string PickupLocation { get; set; }
        [Required]

        public required string ReturnLocation { get; set; }
        [Required]

        [DataType(DataType.Date)]
        public required DateTime FromDate { get; set; } = DateTime.Today;

        [Required]
        [DataType(DataType.Time)]
        public required DateTime FromTime { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public required DateTime UntilDate { get; set; } = DateTime.Today;

        [Required]
        [DataType(DataType.Time)]
        public required DateTime UntilTime { get; set; }
    }
}