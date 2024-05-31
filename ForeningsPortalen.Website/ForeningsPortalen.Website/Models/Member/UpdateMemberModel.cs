using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Member
{
    public class UpdateMemberModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "TelefonNr")]
        public string Phone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Udflytningsdato")]
        public DateOnly? MoveOutDate { get; set; }

        [Display(Name = "Vælg rolle")]
        public Guid RoleId { get; set; }

        [Required]
        public byte[] RowVersion { get; set; } = [];
    }
}
