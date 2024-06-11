using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries
{
    public interface IBookingUnitQueries
    {
        BookingUnitQueryResultDto GetBookingUnitById(Guid id);

        /// <summary>
        /// Get all booking units
        /// </summary>
        /// <returns></returns>
        List<BookingUnitQueryResultDto> GetAllBookingUnits();

        /// <summary>
        /// Get all booking units in a category, using categoryId
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        List<BookingUnitQueryResultDto> GetBookingUnitsByCategoryId(Guid categoryId);

        /// <summary>
        /// Get alle booking units in a booking, using booking Id
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        List<BookingUnitQueryResultDto> GetBookingUnitsByBookingId(Guid bookingId);

        /// <summary>
        /// Get a list of avalible booking time for a booking unit, using a booking unit Id
        /// </summary>
        /// <param name="bookingUnitId"></param>
        /// <returns></returns>
        List<DateTime> GetAvailableTimesForBookingUnit(Guid bookingUnitId);
    }
}
