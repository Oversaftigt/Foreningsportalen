namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking
{
    public class BookingQueryResultDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }

        //Fk
        public List<Guid> BookingUnits { get; set; }
        public Guid UserId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
