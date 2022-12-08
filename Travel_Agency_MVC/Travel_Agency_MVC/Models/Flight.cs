using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travel_Agency_MVC.Models
{
    public class Flight
    {

        [Key]
        [Column("id")]
        public int FlightId { get; set; }

        [Display(Name = "To")]
        public string FlightDestiantion { get; set; } = null!;

        [Display(Name = "From")]
        public string FlightOrigin { get; set; } = null!;

        [Display(Name = "Date")]
        public DateTime FlightDate { get; set; }

        public float Price { get; set; }

        public string FlightSeats { get; set; } = null!;
       
    }
}
