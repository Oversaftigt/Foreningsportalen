using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models
{
    public class BookingUnit
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Navn på bookingenhed")]
        public string? Name { get; set; }

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
        [Display(Name = "Max bookingstids periode")]
        public int MaxBookingDuration { get; set; }

        [Required]
        [Display(Name ="Booking Kategori")]
        public Guid Category { get; set; }

        [Required]
        [Display(Name = "Liste af bookinger, hvor denne enhed er på")]
        public IEnumerable<Guid> Bookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
