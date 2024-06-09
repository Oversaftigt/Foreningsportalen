using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ForeningsPortalen.Website.Models.Member
{
    public class MemberDetailsModel
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

        [Required]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Telefon Nr.")]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Indflytningsdato")]
        public DateOnly? MoveInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Udflytningsdato")]
        public DateOnly? MoveOutDate { get; set; }

        public Guid? AddressId { get; set; }

        [Required]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
