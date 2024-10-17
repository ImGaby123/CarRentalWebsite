using System.ComponentModel.DataAnnotations;

namespace CarRentalWebsite.Areas.Customer.Models
{
    public class Reservation
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string PickUpLocation { get; set; }

        public string ReturnLocation { get; set; }

        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime FromTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime UntilDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime UntilTime { get; set; }
    }
}
