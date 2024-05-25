namespace ForeningsPortalen.Application.Features.Categories.Queries.DTOs
{
    public class CategoryQueryResultDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public string ReservationLimitType { get; set; }
        public int MaxBookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
