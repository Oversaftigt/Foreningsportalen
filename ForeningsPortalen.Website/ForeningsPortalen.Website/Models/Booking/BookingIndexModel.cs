namespace ForeningsPortalen.Website.Models.Booking
{
    public class BookingIndexModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedOndate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string CategoryName { get; set; }

        //Fk
        public List<Guid> BookingUnits { get; set; }
        public Guid UserId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
