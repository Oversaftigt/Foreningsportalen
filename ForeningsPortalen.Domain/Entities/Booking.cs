using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Shared;
using Microsoft.Extensions.DependencyInjection;

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

        //Fk
        public List<BookingUnit> BookingUnits { get; set; }
        public Member User { get; set; }

        public static Booking CreateBooking(DateTime creationDate, DateTime bookingStart,
            DateTime bookingEnd, List<BookingUnit> bookingUnits, Member user, IServiceProvider services)
        {
            if (bookingUnits == null) throw new ArgumentNullException(nameof(bookingUnits));
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (services == null) throw new ArgumentNullException(nameof(services));
            var bookingDomainService = services.GetService<IBookingDomainService>();
            if (bookingDomainService == null) throw new ArgumentNullException(nameof(bookingDomainService));

            if (bookingUnits.Count < 1) throw new InvalidOperationException("Booking must have at least one booking unit");

            var newBooking = new Booking(creationDate, bookingStart, bookingEnd, bookingUnits, user);

            if (newBooking.AreBookingDatesValid() is false)
                throw new InvalidOperationException("Invalid booking dates");

            if (newBooking.AreBookingUnitsAllTheSameCategory() is false)
                throw new InvalidOperationException("Booking units are not all the same category");

            if (newBooking.IsBookingLimitReachedOfCategory(bookingDomainService.OtherBookingsFromAddress(user.Address.AddressId)) is true)
                throw new InvalidOperationException("Max bookings of this category is reached");

            if (newBooking.IsBookingOverlapping(bookingDomainService.OtherBookingsFromUnion(user.Address.Union.UnionId)) is true)
                throw new InvalidOperationException("Booking overlaps with another existing booking");

            return newBooking;
        }


        private bool AreBookingDatesValid()
        {
            if (BookingStart > DateTime.Now) return false;
            if ((BookingStart < BookingEnd) is false) return false; 

            return true;
        }

        private bool IsBookingOverlapping(IEnumerable<Booking> otherBookings)
        {
            //first get the bookings with overlapping time from the same union
            var bookingsWithOverlappingTime = otherBookings.Where(other =>
                (BookingEnd <= other.BookingEnd && BookingEnd >= other.BookingStart) ||
                (BookingStart <= other.BookingEnd && BookingStart >= other.BookingStart) ||
                (BookingStart <= other.BookingStart && BookingEnd >= other.BookingEnd));

            //secondly if there is any bookings that overlap, check is they have overlapping bookingunits used in them
            var bookingUnitsInOverlappingBookings = bookingsWithOverlappingTime.SelectMany(booking => booking.BookingUnits);

            return bookingUnitsInOverlappingBookings
                    .Any(bookingUnit => BookingUnits
                        .Any(x => x.BookingUnitId == bookingUnit.BookingUnitId));

        }

        private bool AreBookingUnitsAllTheSameCategory()
        {
            Guid categoryGuid = BookingUnits[0].Category.CategoryId;
            return BookingUnits.All(bookingUnit => bookingUnit.Category.CategoryId.Equals(categoryGuid));
        }

        private bool IsBookingLimitReachedOfCategory(IEnumerable<Booking> otherBookingsFromThisAddress)
        {
            Guid categoryGuid = BookingUnits[0].Category.CategoryId;
            int maxBookingsOfCategory = BookingUnits[0].Category.MaxBookingsOfThisCategory;
            int currentNumberOfBookingsOfCategory = otherBookingsFromThisAddress
                                                    .Where(booking => booking.BookingUnits[0].Category.CategoryId.Equals(categoryGuid))
                                                    .Count();

            return currentNumberOfBookingsOfCategory >= maxBookingsOfCategory;
        }

    }
}
