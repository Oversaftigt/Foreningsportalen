using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class BookingUnitQueries : IBookingUnitQueries
    {
        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetAllBookingUnits()
        {
            throw new NotImplementedException();
        }

        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByBookingId(Guid bookingId)
        {
            throw new NotImplementedException();
        }

        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
