using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IBookingUnitRepository
    {
        /// <summary>
        /// Add a new booking unit to the database
        /// </summary>
        /// <param name="bookingUnit"></param>
        void AddBookingUnit(BookingUnit bookingUnit);

        /// <summary>
        /// Get a specific booking unit, using its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BookingUnit GetBookingUnit(Guid id);

        /// <summary>
        /// Update an existing booking unit
        /// </summary>
        /// <param name="bookingUnit"></param>
        void UpdateBookingUnit(BookingUnit bookingUnit);

        /// <summary>
        /// Delete booking unit
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteBookingUnit(SharedEntityDeleteDto deleteDto);
    }
}
