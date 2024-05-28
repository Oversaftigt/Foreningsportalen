using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Booking
{
    public class BookingIndexModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Dato for oprettelse")]
        public DateTime CreationDate { get; set; }

        [Required]
        [Display(Name = "Starttidspunkt for booking")]
        public DateTime BookingStart { get; set; }

        [Required]
        [Display(Name = "Sluttidspunkt for booking")]
        public DateTime BookingEnd { get; set; }

        //Fk
        [Required]
        [Display(Name = "Liste over booking enheder")]
        public List<Guid> BookingUnits { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Bruger")]
        public Guid UserId { get; set; }
    }
}
