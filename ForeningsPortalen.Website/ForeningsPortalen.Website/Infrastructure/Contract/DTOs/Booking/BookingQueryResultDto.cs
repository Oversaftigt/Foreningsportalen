namespace ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking
{
    public class BookingQueryResultDto
    {
        public Guid Id { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CategoryName { get; set; }

        //Fk
        public List<Guid> BookingUnitsIds { get; set; }
        public Guid UserId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
