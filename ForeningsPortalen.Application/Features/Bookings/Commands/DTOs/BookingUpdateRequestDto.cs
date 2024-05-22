using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Bookings.Commands.DTOs
{
    public class BookingUpdateRequestDto
    {
        public Guid Id { get; set; }
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
        public Guid UserId { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
