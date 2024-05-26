using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Queries
{
    public interface IBookingQueries
    {

        BookingQueryResultDto GetBookingById(Guid id);

        IEnumerable<BookingQueryResultDto> GetAllBookings();
        IEnumerable<BookingQueryResultDto> GetAllBookingsByMember(Guid memberId);
        IEnumerable<BookingQueryResultDto> GetAllBookingsByAddress(Guid addressId);
    }
}
