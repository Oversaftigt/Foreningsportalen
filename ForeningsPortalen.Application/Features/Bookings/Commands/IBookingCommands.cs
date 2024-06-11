using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Commands
{
    public interface IBookingCommands
    {
        /// <summary>
        /// Creates a booking, based on input in dto
        /// </summary>
        /// <param name="bookingCreateDto"></param>
        void CreateBooking(BookingCreateRequestDto bookingCreateDto);

        /// <summary>
        /// Deletes a booking
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteBooking(SharedEntityDeleteDto deleteDto);

    }
}
