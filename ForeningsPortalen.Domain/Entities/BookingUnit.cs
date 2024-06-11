using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Helpers;
using ForeningsPortalen.Domain.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace ForeningsPortalen.Domain.Entities
{
    public class BookingUnit : Entity
    {
        protected BookingUnit() { }

        internal BookingUnit(string name, bool isActive, double deposit, double price,
                        int maxBookingDuration, Category category)
        {
            Name = name;
            IsActive = isActive;
            Deposit = deposit;
            Price = price;
            MaxBookingDuration = maxBookingDuration;
            Category = category;
        }

        public Guid BookingUnitId { get; private set; }
        public string Name { get; private set; }
        public bool IsActive { get; private set; }
        public double Deposit { get; private set; }
        public double Price { get; private set; }
        public int MaxBookingDuration { get; private set; }
        public Category Category { get; private set; }
        public IEnumerable<Booking> Bookings { get; private set; }

        public static BookingUnit CreateBookingUnit(string name, bool isActive, double deposit, double price,
                        int maxBookingDuration, Category category, IServiceProvider services)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));
            if (category is null) throw new ArgumentNullException(nameof(category));
            if (services is null) throw new ArgumentNullException(nameof(services));

            var domainService = services.GetService<IBookingUnitDomainService>();
            if (domainService is null) throw new ArgumentNullException(nameof(domainService));

            if (DoesBookingUnitNameAlreadyExist(domainService.OtherBookingUnitsFromUnion(category.Union.UnionId), name) is true)
                throw new InvalidOperationException("Booking with that name already exists");

            if (IsDepositValid(deposit) is false)
                throw new InvalidOperationException("Invalid deposit value");

            if (IsPriceValid(price) is false)
                throw new InvalidOperationException("Invalid price value");

            if (IsMaxBookingDurationValid(maxBookingDuration, category.DurationType) is false)
                throw new InvalidOperationException("Invalid value for max booking duration for the category");

            var newBookingUnit = new BookingUnit(name, isActive, deposit, price, maxBookingDuration, category);
            return newBookingUnit;
        }


        private static bool DoesBookingUnitNameAlreadyExist(IEnumerable<BookingUnit> otherBookings, string newBookingUnitName)
        {
            return otherBookings.Any(x => x.Name.ToLower().Trim() == newBookingUnitName.ToLower().Trim());
        }

        private static bool IsDepositValid(double deposit)
        {
            return deposit >= 0;
        }

        private static bool IsPriceValid(double price)
        {
            return price >= 0;
        }

        private static bool IsMaxBookingDurationValid(int duration, BookingDurationType durationType)
        {

            if (durationType == BookingDurationType.Days)
            {
                return (duration > 0 && duration <= 2);
            }

            if (durationType == BookingDurationType.Hours)
            {
                return (duration > 0 && duration <= 3);
            }

            throw new InvalidDataException("BookingDurationType invalid");
        }
    }
}
