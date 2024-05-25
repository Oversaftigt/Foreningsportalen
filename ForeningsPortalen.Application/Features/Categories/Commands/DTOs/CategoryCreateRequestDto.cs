namespace ForeningsPortalen.Application.Features.Categories.Commands.DTOs
{
    public class CategoryCreateRequestDto
    {
        public string CategoryName { get; set; }
        public string ReservationLimitType { get; set; }
        public int MaxBookings { get; set; }
        public Guid UnionId { get; set; }
    }
}
