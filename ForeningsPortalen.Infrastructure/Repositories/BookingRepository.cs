using ForeningsPortalen.Application.Features.Bookings.Commands.DTOs;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
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
            _dbContext.Add(booking);
            _dbContext.SaveChanges();
        }

        void IBookingRepository.DeleteBooking(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
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
