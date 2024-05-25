namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs
{
    public class BookingUnitUpdateRequestDto
    {
        public Guid Id { get; set; }
        public string BookingUnitName { get; set; }
        public bool IsBookingUnitActive { get; set; }
        public double AdvancePayment { get; set; }
        public double Fee { get; set; }
        public int ReservationLimit { get; set; }
        public Guid CategoryId { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
