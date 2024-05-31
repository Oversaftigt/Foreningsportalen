namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.BookingUnit
{
    public class BookingUnitQueryResultDto
    {
        public Guid Id { get; set; }
        public string BookingUnitName { get; set; }
        public bool IsBookingUnitActive { get; set; }
        public double AdvancePayment { get; set; }
        public double Fee { get; set; }
        public int ReservationLimit { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<Guid> BookingIds { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
