namespace ForeningsPortalen.Website.DTOs.Booking
{
    public class BookingCreateRequestDto
    {
        public DateTime CreationDate { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }

        //Fk
        public List<Guid> BookingUnits { get; set; }
        public Guid UserId { get; set; }
    }
}
