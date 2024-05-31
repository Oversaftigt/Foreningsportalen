using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Category
{
    public class CreateCategoryModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "{0} Skal være mindst {2} og højst {1} karaktere lang.", MinimumLength = 2)]
        [Display(Name = "Kategori Navn")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Vælg Reservationstype")]
        public string DurationType { get; set; }

        [Required]
        [Display(Name = "Vælg maximum antal bookinger")]
        public int MaxBookingsOfThisCategory { get; set; }

        [Required]
        [Display(Name = "Vælg Bolig Forening")]
        public Guid UnionId { get; set; }
    }
}
