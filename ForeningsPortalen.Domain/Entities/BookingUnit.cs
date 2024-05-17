using ForeningsPortalen.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Domain.Entities
{
    public class BookingUnit : Entity
    {
        internal BookingUnit() : base(Guid.NewGuid())
        {
            
        }
        public BookingUnit(Guid id,string name, bool isActive, double deposit, double price, 
                        int maxBookingDuration, Category category, List<Booking> bookings) : base(id)
        {
            Name = name;
            IsActive = isActive;
            Deposit = deposit;
            Price = price;
            MaxBookingDuration = maxBookingDuration;
            Category = category;
            Bookings = bookings;
        }



        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double Deposit { get; set; }
        public double Price { get; set; }
        public int MaxBookingDuration { get; set; }
        public Category Category { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
