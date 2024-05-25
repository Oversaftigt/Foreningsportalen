namespace ForeningsPortalen.Application.Features.Categories.Commands.DTOs
{
    public class CategoryUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string ReservationLimitType { get; set; }
        public int MaxBookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
