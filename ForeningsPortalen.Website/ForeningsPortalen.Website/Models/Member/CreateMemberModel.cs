using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Member
{
    public class CreateMemberModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Kodeord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft Kodeord")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "TelefonNr")]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Indflytningsdato")]
        public DateTime MoveInDate { get; set; }

        [Required]
        [Display(Name = "Vælg rolle")]
        public Guid RoleId { get; set; }

        [Required]
        public Guid AddressId { get; set; }

    }
}
