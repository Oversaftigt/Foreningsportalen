using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IBookingRepository
    {
        void AddBooking(Booking booking);
        void UpdateBooking(Booking booking);
        void DeleteBooking(SharedEntityDeleteDto deleteDto);
        Booking GetBooking(Guid id);
    }
}
