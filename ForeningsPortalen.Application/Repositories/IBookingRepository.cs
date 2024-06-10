using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IBookingRepository
    {
        /// <summary>
        /// Add a new booking to the database
        /// </summary>
        /// <param name="booking"></param>
        void AddBooking(Booking booking);
        /// <summary>
        /// Updsate an existing booking in the database
        /// </summary>
        /// <param name="booking"></param>
        void UpdateBooking(Booking booking);

        /// <summary>
        /// Delete a booking
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteBooking(SharedEntityDeleteDto deleteDto);

        /// <summary>
        /// Get a specific booking from the database, using its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Booking GetBooking(Guid id);
    }
}
