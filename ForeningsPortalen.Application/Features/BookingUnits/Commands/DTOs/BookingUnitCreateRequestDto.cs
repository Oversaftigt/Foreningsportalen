namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs
{
    public class BookingUnitCreateRequestDto
    {
        public string BookingUnitName { get; set; }
        public bool IsBookingUnitActive { get; set; }
        public double AdvancePayment { get; set; }
        public double Fee { get; set; }
        public int ReservationLimit { get; set; }
        public Guid CategoryId { get; set; }
    }
}
