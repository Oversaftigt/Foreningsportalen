using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Bookings.Commands.Implementations
{
    public class BookingCommands : IBookingCommands
    {
        void IBookingCommands.CreateBooking(BookingCreateRequestDto bookingCreateDto)
        {
            throw new NotImplementedException();
        }

        void IBookingCommands.DeleteBooking(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        void IBookingCommands.UpdateBooking(BookingUpdateRequestDto bookingUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
