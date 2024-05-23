
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ForeningsPortalen.WebApp.ViewModels.MemberViews
{
    public class RegisterMemberViewModel : BaseLayoutViewModel
    {
        [Display(Name = "Fornavn")]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Efternavn")]
        [StringLength(25, MinimumLength = 3)]
        public string LastName { get; set; }

        [JsonPropertyName("E-mail adresse")]
        public string Email { get; set; }

        [Display(Name = "Telefon nr.")]
        [JsonPropertyName("PhoneNumber")]
        public string Phone { get; set; }

        [Display(Name = "Indflytningsdato")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        [JsonPropertyName("MoveInDate")]
        public DateOnly MoveIn { get; set; }

        [Display(Name = "Adresse")]
        public Guid AdresseId { get; set; }

        [Display(Name = "Rolle")]
        public string Role { get; set; }

    }
}
