using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Booking
{
    public class CreateBookingModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Booking navn")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Skal bookingen være aktiv?")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Depositum")]
        public double Deposit { get; set; }

        [Required]
        [Display(Name = "Pris")]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Sæt max bookingstids periode")]
        public int MaxBookingDuration { get; set; }

        [Required]
        [Display(Name = "Tilføj til kategori")]
        public Guid CategoryId { get; set; }
    }
}
