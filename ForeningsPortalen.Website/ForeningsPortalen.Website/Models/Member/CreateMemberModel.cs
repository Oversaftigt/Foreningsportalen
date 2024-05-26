using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Member
{
    public class CreateMemberModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Kodeord")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekræft Kodeord")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
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
        public DateOnly MoveInDate { get; set; }

        [Required]
        [Display(Name = "Rolle")]
        public Guid Role { get; set; }

        [Required]
        public Guid AddressId { get; set; }
        
        [Required]
        public required Guid UnionId { get; set; }

    }
}
