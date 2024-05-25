using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class BookingUnitQueries : IBookingUnitQueries
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BookingUnitQueries(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
        List<BookingUnit> IBookingUnitQueries.GetAllBookingUnits()
        {
            var bookingUnits = _dbContext.BookingUnit.AsNoTracking()
                .Select(b => new BookingUnit
                {
                    BookingUnitId = b.BookingUnitId,
                    Name = b.Name,
                    IsActive = b.IsActive,
                    Deposit = b.Deposit,
                    Price = b.Price,
                    MaxBookingDuration = b.MaxBookingDuration,
                    Category = b.Category,
                    Bookings = b.Bookings,
                }).ToList();
            return bookingUnits;
        }

        List<BookingUnit> IBookingUnitQueries.GetBookingUnitsByBookingId(Guid bookingId)
        {
            throw new NotImplementedException();
        }

        List<BookingUnit> IBookingUnitQueries.GetBookingUnitsByCategoryId(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
