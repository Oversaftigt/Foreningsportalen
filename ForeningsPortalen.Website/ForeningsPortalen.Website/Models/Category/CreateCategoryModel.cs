namespace ForeningsPortalen.Website.Models.Category
{
    public class CreateCategoryModel
    {
        public string Name { get; set; }
        public string DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public Guid UnionId { get; set; }
    }
}
