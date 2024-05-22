using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Booking : Entity
    {
        public Booking()
        {
        }
        internal Booking(DateTime creationDate, DateTime bookingStart, 
            DateTime bookingEnd, List<BookingUnit> bookingUnits, Member user)
        {
            CreationDate = creationDate;
            BookingStart = bookingStart;
            BookingEnd = bookingEnd;
            BookingUnits = bookingUnits;
            User = user;
        }

        public Guid BookingId { get; set; }
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
        public List<BookingUnit> BookingUnits { get; set; }
        public Member User { get; set; }

        public static Booking CreateBooking(DateTime creationDate, DateTime bookingStart,
            DateTime bookingEnd, List<BookingUnit> bookingUnits, Member user)
        {
            if(bookingUnits == null) throw new ArgumentNullException(nameof(bookingUnits));
            if(user == null) throw new ArgumentNullException(nameof(user));

            if (bookingUnits.Count < 1) throw new InvalidOperationException("Booking must have at least one booking unit");

            var newBooking = new Booking(creationDate, bookingStart, bookingEnd, bookingUnits, user);
                return newBooking;
        }




    }
}
