using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ForeningsPortalen.WebApp.Models
{
    public class UnionMemberViewModel
    {
        [JsonPropertyName("Id")]
        public Guid MemberId { get; set; }

        [Display(Name = "Fornavn")]
        public string FirstName { get; set; }
        
        [Display(Name = "Efternavn")]
        public string LastName { get; set; }

        [JsonPropertyName("E-mail adresse")]
        public string Email { get; set; }


        [JsonPropertyName("phoneNumber")]
        [Display(Name ="Telefon nr.")]
        public string Phone { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        [Display(Name = "Indflytningsdato")]
        public DateOnly MoveInDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

    }
}
