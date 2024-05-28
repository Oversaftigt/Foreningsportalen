namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.BookingUnit
{
    public class BookingUnitQueryResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public int MaxBookingDuration { get; set; }
        public Guid Category { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
