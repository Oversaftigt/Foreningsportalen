using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Union
{
    public class EditUnion
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "BoligForeningens Navn")]
        public string Name { get; set; }

        [Required]
        public byte[] RowVersion { get; set; }
    }
}
