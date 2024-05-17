namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs
{
    public class BookingUnitCreateRequestDto
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public int MaxBookingDuration { get; set; }
        public Guid CategoryId { get; set; }
    }
}
