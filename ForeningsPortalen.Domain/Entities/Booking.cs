using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Booking : Entity
    {
        public Booking(Guid id) : base(id)
        {
        }

        public int Id { get; }
        public DateTime CreationDate { get; set; }
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }
        public string CategoryName
        {
            get
            {
                return BookingUnits[0].Category.Name;
            }
        }

        //Fk
        public required List<BookingUnit> BookingUnits { get; set; }
        public Address AddressInformation { get; set; }
        public Member User { get; set; }
    }
}
