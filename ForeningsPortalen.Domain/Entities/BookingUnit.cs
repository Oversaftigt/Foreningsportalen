using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class BookingUnit : Entity
    {
        public BookingUnit()
        {

        }
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

        public Guid BookingUnitId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public int MaxBookingDuration { get; set; }
        public Category Category { get; set; }
        public List<Booking> Bookings { get; set; }

        public static BookingUnit CreateBookingUnit(string name, bool isActive, double deposit, double price,
                        int maxBookingDuration, Category category)
        {
            var newBookingUnit = new BookingUnit(name, isActive, deposit, price, maxBookingDuration, category);
            return newBookingUnit;
        }

    }
}
