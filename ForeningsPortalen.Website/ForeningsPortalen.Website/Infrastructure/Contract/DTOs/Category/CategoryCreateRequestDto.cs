namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category
{
    public class CategoryCreateRequestDto
    {
        public string CategoryName { get; set; }
        public string ReservationLimitType { get; set; }
        public int MaxBookings { get; set; }
        public Guid UnionId { get; set; }
    }
}
