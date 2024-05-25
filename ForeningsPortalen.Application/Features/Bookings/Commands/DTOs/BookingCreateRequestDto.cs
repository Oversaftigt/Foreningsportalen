namespace ForeningsPortalen.Application.Features.Bookings.Commands.DTOs
{
    public class BookingCreateRequestDto
    {
        public DateTime DateOfCreation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //Fk
        public IEnumerable<Guid> BookingUnitsID { get; set; }
        public Guid UserId { get; set; }
    }
}
