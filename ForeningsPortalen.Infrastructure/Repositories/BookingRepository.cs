using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        void IBookingRepository.DeleteBooking(Booking booking, byte[] rowversion)
        {
            throw new NotImplementedException();
        }

        Booking IBookingRepository.GetBooking(Guid id)
        {
            throw new NotImplementedException();
        }

        void IBookingRepository.UpdateBooking(Booking booking, byte[] rowversion)
        {
            throw new NotImplementedException();
        }
    }
}
