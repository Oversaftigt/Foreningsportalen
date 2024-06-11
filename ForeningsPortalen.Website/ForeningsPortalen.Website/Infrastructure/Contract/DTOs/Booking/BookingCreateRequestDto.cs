namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking
{
    public class BookingCreateRequestDto
    {
        public DateTime DateOfCreation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //Fk
        public List<Guid> BookingUnitsID { get; set; }
        public Guid UserId { get; set; }
    }
}
