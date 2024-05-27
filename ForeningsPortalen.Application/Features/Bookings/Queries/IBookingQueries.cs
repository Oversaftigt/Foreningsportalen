using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Queries
{
    public interface IBookingQueries
    {

        BookingQueryResultDto GetBookingById(Guid id);

        IEnumerable<BookingQueryResultDto> GetAllBookings();
        IEnumerable<BookingQueryResultDto> GetAllFutureBookingsByMember(Guid memberId);
        IEnumerable<BookingQueryResultDto> GetAllFutureBookingsByAddress(Guid addressId);
    }
}
