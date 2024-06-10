using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands
{
    public interface IBookingUnitCommands
    {
        /// <summary>
        /// Create a booking unit, using a dto
        /// </summary>
        /// <param name="dto"></param>
        void CreateBookingUnit(BookingUnitCreateRequestDto dto);

        /// <summary>
        /// Update the booking unit, using a dto
        /// </summary>
        /// <param name="dto"></param>
        void UpdateBookingUnit(BookingUnitUpdateRequestDto dto);

        /// <summary>
        /// Delete a booking unit
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteBookingUnit(SharedEntityDeleteDto deleteDto);
    }
}
