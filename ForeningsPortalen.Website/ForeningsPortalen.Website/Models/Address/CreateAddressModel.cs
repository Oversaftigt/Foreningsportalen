using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Address
{
    public class CreateAddressModel
    {
        [Required]
        [Display(Name = "Vej navn")]
        public string Street { get; set; }

        [Required]
        [Display(Name = "Vej nummer")]
        public int StreetNumber { get; set; }

        [Display(Name = "Etage")]
        public string? Floor { get; set; }

        [Display(Name = "Dør, eks tv eller 2D")]
        public string? Door { get; set; }

        [Required]
        [Display(Name = "By")]
        public string City { get; set; }

        [Required]
        [Display(Name = "Postnummer")]
        public int ZipCode { get; set; }
    }
}
