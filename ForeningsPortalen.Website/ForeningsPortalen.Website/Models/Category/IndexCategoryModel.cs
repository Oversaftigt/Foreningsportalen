namespace ForeningsPortalen.Website.Models.Category
{
    public class IndexCategoryModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
    }
}
