using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Queries
{
    public interface IBookingQueries
    {

        BookingQueryResultDto GetBookingById(Guid id);
        List<BookingQueryResultDto> GetAllBookings();
    }
}
