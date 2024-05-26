namespace ForeningsPortalen.Website.DTOs.Category
{
    public class CategoryQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DurationType { get; set; }
        public int MaxBookingsOfThisCategory { get; set; }
        public Guid UnionId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
