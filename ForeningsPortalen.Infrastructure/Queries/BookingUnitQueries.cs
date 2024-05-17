using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class BookingUnitQueries : IBookingUnitQueries
    {
        IEnumerable<BookingUnitQueryResultDto> IBookingUnitQueries.GetAllBookingUnits()
        {
            throw new NotImplementedException();
        }

        IEnumerable<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByBookingId(Guid bookingId)
        {
            throw new NotImplementedException();
        }
    }
}
