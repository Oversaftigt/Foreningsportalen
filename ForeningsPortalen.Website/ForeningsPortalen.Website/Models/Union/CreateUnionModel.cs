using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Union
{
    public class CreateUnionModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
