namespace ForeningsPortalen.Website.DTOs.Category
{
    public class CategoryCreateRequestDto
    {
        public string Name { get; set; }
        public string DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public Guid UnionId { get; set; }
    }
}
