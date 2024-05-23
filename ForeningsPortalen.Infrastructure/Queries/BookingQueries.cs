using ForeningsPortalen.Infrastructure.Database.Configuration;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class BookingQueries : IBookingQueries
    {
        private readonly ForeningsPortalenContext _dbContext;

        public BookingQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        List<BookingQueryResultDto> IBookingQueries.GetAllBookings()
        {
            //var result = _dbContext.Bookings.AsNoTracking()
            //    .Select(b => new BookingQueryResultDto
            //    {
            //        Id = b.BookingId,
            //        CreationDate = b.CreationDate,
            //        BookingStart = b.BookingStart,
            //        BookingEnd = b.BookingEnd,
            //        CategoryName = b.CategoryName,
            //        UserId = b.User, //Booking bruger en member og kalder den for user, dto bruger guid userId
            //        Rowversion = b.RowVersion,
            //    }).ToList();

            //if (result == null)
            //{
            //    throw new ArgumentNullException("Booking not found");
            //}
            //return result;

            throw new NotImplementedException();

        }

        BookingQueryResultDto IBookingQueries.GetBookingById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
