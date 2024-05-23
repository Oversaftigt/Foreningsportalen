using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Bookings.Commands
{
    public interface IBookingCommands
    {
        //(Indeholder Create, Update og Delete metoder. DTO'er bliver brugt bl.a.)
        void UpdateBooking(BookingUpdateRequestDto bookingUpdateDto);
        void CreateBooking(BookingCreateRequestDto bookingCreateDto);
        void DeleteBooking(SharedEntityDeleteDto deleteDto);

    }
}
