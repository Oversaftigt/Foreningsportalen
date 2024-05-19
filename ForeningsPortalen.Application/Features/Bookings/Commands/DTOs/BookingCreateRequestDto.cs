using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Bookings.Commands.DTOs
{
    public class BookingCreateRequestDto
    {
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
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
    }
}
