using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands
{
    public interface IBookingUnitCommands
    {
        void CreateBookingUnit(BookingUnitCreateRequestDto dto);
        void UpdateBookingUnit(BookingUnitUpdateRequestDto dto);
        void DeleteBookingUnit(SharedEntityDeleteDto deleteDto);
    }
}
