using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models
{
    public class Document
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Navn på dokumentet")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Navn på den person, der har lagt dokumentet op")]
        public Guid UploadedBy { get; set; }

        [Required]
        [Display(Name ="Datoen dokumentet er lagt op")]
        public DateOnly Date { get; set; }

        [Required]
        public byte[] RowVersion { get; set; }
    }
}
