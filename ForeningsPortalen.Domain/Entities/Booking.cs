using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace ForeningsPortalen.Domain.Entities
{
    public class Booking : Entity
    {
        protected Booking()
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

        public Guid BookingId { get; private set; }
        public DateTime CreationDate { get; private set; }
        public DateTime BookingStart { get; private set; }
        public DateTime BookingEnd { get; private set; }

        //Fk
        public List<BookingUnit> BookingUnits { get; private set; }
        public Member User { get; private set; }

        public static Booking CreateBooking(DateTime creationDate, DateTime bookingStart,
            DateTime bookingEnd, List<BookingUnit> bookingUnits, Member user, IServiceProvider services)
        {
            if (bookingUnits == null) throw new ArgumentNullException(nameof(bookingUnits));
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (services == null) throw new ArgumentNullException(nameof(services));
            var bookingDomainService = services.GetService<IBookingDomainService>();
            if (bookingDomainService == null) throw new ArgumentNullException(nameof(bookingDomainService));

            if (bookingUnits.Count < 1) throw new InvalidOperationException("Booking must have at least one booking unit");

            //recreate the datetimes with seconds set to 0(this ensures seconds, milliseconds etc are 0, because if it is not it messes with bookingvalidation)
            DateTime newBookingStart = SetDatetimeSecondsToZero(bookingStart);
            DateTime newBookingEnd = SetDatetimeSecondsToZero(bookingEnd);

            if (AreBookingDatesValid(newBookingStart, newBookingEnd) is false)
                throw new InvalidOperationException("Invalid booking dates");

            if (AreBookingUnitsAllTheSameCategory(bookingUnits) is false)
                throw new InvalidOperationException("Booking units are not all the same category");

            if (IsBookingLimitReachedOfCategory(bookingDomainService.OtherBookingsFromAddress(user.Address.AddressId), bookingUnits[0]) is true)
                throw new InvalidOperationException("Max bookings of this category is reached");

            if (IsBookingOverlapping(bookingDomainService.OtherBookingsFromUnion(user.Address.Union.UnionId),
                                                           newBookingStart, newBookingEnd, bookingUnits) is true)
                throw new InvalidOperationException("Booking overlaps with another existing booking");

            if (IsBookingWithinAllowedDuration(newBookingStart, newBookingEnd, bookingUnits) is false)
                throw new InvalidOperationException("Booking duration exceeds the allowed amount for at least one of the bookingunits");

            var newBooking = new Booking(creationDate, newBookingStart, newBookingEnd, bookingUnits, user);

            return newBooking;
        }


        private static bool AreBookingDatesValid(DateTime bookingStart, DateTime bookingEnd)
        {
            if (bookingStart < DateTime.Now) return false; //Check if booking is being made in the past
            if (bookingStart < bookingEnd is false) return false; //Check if booking end time is after the start time

            return true;
        }


        // Check if booking is overlapping with other bookings that have at least one of the same bookingunit
        private static bool IsBookingOverlapping(IEnumerable<Booking> otherBookings, DateTime bookingStart,
                                                 DateTime bookingEnd, IEnumerable<BookingUnit> currentBookingUnits)
        {
            //first get the bookings with overlapping time from the same union
            var bookingsWithOverlappingTime = otherBookings.Where(other =>
                                              (bookingEnd > other.BookingStart && bookingStart < other.BookingEnd));


            //secondly, gets the bookingunits from the overlapping bookings as a list
            var bookingUnitsInOverlappingBookings = bookingsWithOverlappingTime.SelectMany(booking => booking.BookingUnits);

            //Checks if any bookingunits from bookingUnitsInOverlappingBookings is the same as any bookingunit in the current booking that is being made
            foreach (var otherBookingUnit in bookingUnitsInOverlappingBookings)
            {
                bool isOverlapping = currentBookingUnits.Any(x => x.BookingUnitId == otherBookingUnit.BookingUnitId);

                if (isOverlapping is true)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool AreBookingUnitsAllTheSameCategory(List<BookingUnit> bookingUnits)
        {
            Guid categoryGuid = bookingUnits[0].Category.CategoryId;
            return bookingUnits.All(bookingUnit => bookingUnit.Category.CategoryId.Equals(categoryGuid));
        }

        private static bool IsBookingLimitReachedOfCategory(IEnumerable<Booking> otherBookingsFromThisAddress, BookingUnit bookingUnit)
        {
            Guid categoryGuid = bookingUnit.Category.CategoryId;
            int maxBookingsOfCategory = bookingUnit.Category.MaxBookingsOfThisCategory;
            int currentNumberOfBookingsOfCategory = otherBookingsFromThisAddress
                                                    .Where(booking => booking.BookingUnits[0].Category.CategoryId.Equals(categoryGuid))
                                                    .Count();

            return currentNumberOfBookingsOfCategory >= maxBookingsOfCategory;
        }

        private static bool IsBookingWithinAllowedDuration(DateTime start, DateTime end, List<BookingUnit> bookingUnits)
        {
            if (bookingUnits[0].Category.DurationType is Helpers.BookingDurationType.Hours)
            {
                TimeSpan duration = end - start;
                return bookingUnits.All(bookingUnit => duration.TotalHours <= bookingUnit.MaxBookingDuration);
            }
            if (bookingUnits[0].Category.DurationType is Helpers.BookingDurationType.Days)
            {
                TimeSpan duration = end - start;
                return bookingUnits.All(bookingUnit => duration.Days <= bookingUnit.MaxBookingDuration);
            }
            throw new Exception("Error validating if booking duration is allowed");
        }

        //method to have seconds equal 0 in datetime
        private static DateTime SetDatetimeSecondsToZero(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day,
                                dateTime.Hour, dateTime.Minute, 0);
        }

    }
}
