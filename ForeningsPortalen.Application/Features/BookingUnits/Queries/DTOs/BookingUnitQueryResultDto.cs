using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs
{
    public class BookingUnitQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public int MaxBookingDuration { get; set; }
        public Category Category { get; set; }
        public List<Booking> Bookings { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
