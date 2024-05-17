using ForeningsPortalen.Application.Features.BookingUnits.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.BookingUnits.Commands.Interfaces
{
    public interface IBookingUnitCommands
    {
        void AddBookingUnit(BookingUnitCreateRequestDto dto);
        void UpdateBookingUnit(BookingUnitUpdateRequestDto dto);
        void DeleteBookingUnit(Guid id);
    }
}
