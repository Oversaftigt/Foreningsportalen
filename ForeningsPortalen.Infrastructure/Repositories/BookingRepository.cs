using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BookingRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IBookingRepository.AddBooking(Booking booking)
        {
            _dbContext.Add(booking);
            _dbContext.SaveChanges();
        }

        void IBookingRepository.DeleteBooking(SharedEntityDeleteDto deleteDto)
        {
            var booking = _dbContext.Bookings.FirstOrDefault(b => b.BookingId == deleteDto.Id);
            if (booking is not null)
            {
                _dbContext.Bookings.Remove(booking);
                _dbContext.SaveChanges();
            }
        }

        Booking IBookingRepository.GetBooking(Guid id)
        {
            var booking = _dbContext.Bookings.Find(id);
            return booking;
        }

        void IBookingRepository.UpdateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }
    }
}
