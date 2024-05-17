using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries.Interfaces
{
    public interface IBookingUnitQueries
    {
        IEnumerable<BookingUnitQueryResultDto> GetAllBookingUnits();
        IEnumerable<BookingUnitQueryResultDto> GetBookingUnitsByCategoryId(Guid categoryId);
        IEnumerable<BookingUnitQueryResultDto> GetBookingUnitsByBookingId(Guid bookingId);
    }
}
