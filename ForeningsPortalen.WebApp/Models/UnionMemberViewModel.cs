using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ForeningsPortalen.WebApp.Models
{
    public class UnionMemberViewModel
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

        [Display(Name ="Telefon nr.")]
        [JsonPropertyName("phoneNumber")]
        public string Phone { get; set; }
        
        [Display(Name = "Indflytningsdato")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        [JsonPropertyName("MoveInDate")]
        public DateOnly MoveIn { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
