using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Union
{
    public class IndexUnion
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "BoligForeningens Navn")]
        public string Name { get; set; }
    }
}
