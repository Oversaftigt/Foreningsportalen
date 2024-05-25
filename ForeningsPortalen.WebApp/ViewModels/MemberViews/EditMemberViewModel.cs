using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ForeningsPortalen.WebApp.ViewModels.MemberViews
{
    public class EditMemberViewModel : BaseLayoutViewModel
    {
        [JsonPropertyName("Id")]
        public Guid MemberId { get; set; }

        [Display(Name = "Fornavn")]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Efternavn")]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [JsonPropertyName("E-mail adresse")]
        public string Email { get; set; }

        [Display(Name = "Telefon nr.")]
        [JsonPropertyName("phoneNumber")]
        public string Phone { get; set; }

        [Display(Name = "Rolle")]
        public string Role { get; set; }

        [Display(Name = "Udflytningsdato")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        [JsonPropertyName("MoveOutDate")]
        public DateOnly MoveOut { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
