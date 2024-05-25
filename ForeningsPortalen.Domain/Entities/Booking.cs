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


            if (AreBookingDatesValid(bookingStart, bookingEnd) is false)
                throw new InvalidOperationException("Invalid booking dates");

            if (AreBookingUnitsAllTheSameCategory(bookingUnits) is false)
                throw new InvalidOperationException("Booking units are not all the same category");

            if (IsBookingLimitReachedOfCategory(bookingDomainService.OtherBookingsFromAddress(user.Address.AddressId), bookingUnits) is true)
                throw new InvalidOperationException("Max bookings of this category is reached");

            if (IsBookingOverlapping(bookingDomainService.OtherBookingsFromUnion(user.Address.Union.UnionId),
                                                           bookingStart, bookingEnd, bookingUnits) is true)
                throw new InvalidOperationException("Booking overlaps with another existing booking");

            var newBooking = new Booking(creationDate, bookingStart, bookingEnd, bookingUnits, user);

            return newBooking;
        }


        private static bool AreBookingDatesValid(DateTime bookingStart, DateTime bookingEnd)
        {
            if (bookingStart < DateTime.Now) return false; //Check if booking is being made in the past
            if (bookingStart < bookingEnd is false) return false; //Check if booking end time is after the start time

            return true;
        }

        private static bool IsBookingOverlapping(IEnumerable<Booking> otherBookings, DateTime bookingStart,
                                                 DateTime bookingEnd, IEnumerable<BookingUnit> bookingUnits)
        {
            //first get the bookings with overlapping time from the same union
            var bookingsWithOverlappingTime = otherBookings.Where(other =>
                                              (bookingEnd > other.BookingStart && bookingStart < other.BookingEnd));


            //secondly if there is any bookings that overlap, check is they have overlapping bookingunits used in them
            var bookingUnitsInOverlappingBookings = bookingsWithOverlappingTime.SelectMany(booking => booking.BookingUnits);

            return bookingUnitsInOverlappingBookings
                    .Any(bookingUnit => bookingUnits
                        .Any(x => x.BookingUnitId == bookingUnit.BookingUnitId));

        }

        private static bool AreBookingUnitsAllTheSameCategory(List<BookingUnit> bookingUnits)
        {
            Guid categoryGuid = bookingUnits[0].Category.CategoryId;
            return bookingUnits.All(bookingUnit => bookingUnit.Category.CategoryId.Equals(categoryGuid));
        }

        private static bool IsBookingLimitReachedOfCategory(IEnumerable<Booking> otherBookingsFromThisAddress, List<BookingUnit> bookingUnits)
        {
            Guid categoryGuid = bookingUnits[0].Category.CategoryId;
            int maxBookingsOfCategory = bookingUnits[0].Category.MaxBookingsOfThisCategory;
            int currentNumberOfBookingsOfCategory = otherBookingsFromThisAddress
                                                    .Where(booking => booking.BookingUnits[0].Category.CategoryId.Equals(categoryGuid))
                                                    .Count();

            return currentNumberOfBookingsOfCategory >= maxBookingsOfCategory;
        }

        private static bool IsBookingWithinAllowedDuration(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

    }
}
