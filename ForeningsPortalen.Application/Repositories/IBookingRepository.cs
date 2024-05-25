using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;

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
