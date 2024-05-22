using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Bookings.Queries
{
    public interface IBookingQueries
    {

        BookingQueryResultDto GetBookingById(Guid id);
        List<BookingQueryResultDto> GetAllBookings();
    }
}
