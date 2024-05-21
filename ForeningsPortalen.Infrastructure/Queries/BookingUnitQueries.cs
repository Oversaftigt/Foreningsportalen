using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;

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
