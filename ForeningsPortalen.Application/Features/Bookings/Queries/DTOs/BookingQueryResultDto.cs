namespace ForeningsPortalen.Application.Features.Bookings.Queries.DTOs
{
    public class BookingQueryResultDto
    {
        public Guid Id { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CategoryName { get; set; }
        //Fk
        public IEnumerable<Guid> BookingUnitIds { get; set; }
        public Guid UserId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
