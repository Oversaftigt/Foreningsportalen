using ForeningsPortalen.Application.Features.Bookings.Queries;
using ForeningsPortalen.Application.Features.Bookings.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
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
            var result = _dbContext.Bookings.AsNoTracking()
                 .Include(b => b.BookingUnits) // Ensure BookingUnits are included
                 .ThenInclude(bo => bo.Category) // Ensure CategoryId within BookingUnits are included
                 .Select(b => new BookingQueryResultDto
                 {
                     Id = b.BookingId,
                     DateOfCreation = b.CreationDate,
                     StartTime = b.BookingStart,
                     EndTime = b.BookingEnd,
                     BookingUnitIds = b.BookingUnits.Select(x => x.BookingUnitId), // Map BookingUnits
                     UserId = b.User.UserId,
                     Rowversion = b.RowVersion,
                 }).ToList();

            if (result == null || !result.Any())
            {
                throw new ArgumentNullException("Booking not found");
            }
            return result;

        }

        BookingQueryResultDto IBookingQueries.GetBookingById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
