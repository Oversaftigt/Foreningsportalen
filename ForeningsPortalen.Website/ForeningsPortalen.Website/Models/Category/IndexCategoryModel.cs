using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Models.Category
{
    public class IndexCategoryModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Kategori Navn")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Vælg Reservationstype")]
        public string DurationType { get; set; }
      
        [Required]
        [Display(Name = "Vælg maximum antal bookinger")]
        public int MaxBookingsOfThisCategory { get; set; }
    }
}
