using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Queries
{
    public interface IBookingQueries
    {
        /// <summary>
        /// Get one booking by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookingQueryResultDto GetBookingById(Guid id);

        /// <summary>
        /// Get all bookings
        /// </summary>
        /// <returns></returns>
        IEnumerable<BookingQueryResultDto> GetAllBookings();
        
        /// <summary>
        /// Get all future bookings belonging to one member, by using memberId
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        IEnumerable<BookingQueryResultDto> GetAllFutureBookingsByMember(Guid memberId);

        /// <summary>
        /// Get all bookings belonging to a specific address, by address Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        IEnumerable<BookingQueryResultDto> GetAllFutureBookingsByAddress(Guid addressId);
    }
}
