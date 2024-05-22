using ForeningsPortalen.Infrastructure.Database.Configuration;
using ForeningsPortalen.Application.Features.Bookings.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;

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
            throw new NotImplementedException();
        }

        BookingQueryResultDto IBookingQueries.GetBookingById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
