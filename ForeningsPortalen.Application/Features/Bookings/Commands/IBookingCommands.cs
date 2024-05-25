using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Bookings.Commands
{
    public interface IBookingCommands
    {
        //(Indeholder Create, Update og Delete metoder. DTO'er bliver brugt bl.a.)
        void CreateBooking(BookingCreateRequestDto bookingCreateDto);
        void DeleteBooking(SharedEntityDeleteDto deleteDto);

    }
}
