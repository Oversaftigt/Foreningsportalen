using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.BookingUnits.Repositories
{
    public interface IBookingUnitRepository
    {
        void AddBookingUnit(BookingUnit BookingUnit);
        BookingUnit GetBookingUnit(Guid id);
        void UpdateBookingUnit(BookingUnit BookingUnit, byte[] rowVersion);
        void DeleteBookingUnit(BookingUnit BookingUnit, byte[] rowVersion);
    }
}
