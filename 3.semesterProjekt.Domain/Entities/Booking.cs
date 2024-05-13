using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Domain.Entities
{
    public class Booking
    {
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
        public User User { get; set; }
    }
}
