using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
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
        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetAllBookingUnits()
        {
            var bookingUnits = _dbContext.BookingUnit.AsNoTracking()
                .Include(b => b.Bookings)
                .Select(b => new BookingUnitQueryResultDto
                {
                    Id = b.BookingUnitId,
                    BookingUnitName = b.Name,
                    IsBookingUnitActive = b.IsActive,
                    AdvancePayment = b.Deposit,
                    Fee = b.Price,
                    ReservationLimit = b.MaxBookingDuration,
                    CategoryId = b.Category.CategoryId,
                    BookingIds = b.Bookings.Select(x => x.BookingId).ToList(),
                    RowVersion = b.RowVersion,
                }).ToList();
            return bookingUnits;
        }


        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByBookingId(Guid bookingId)
        {
            throw new NotImplementedException();
        }

        List<BookingUnitQueryResultDto> IBookingUnitQueries.GetBookingUnitsByCategoryId(Guid categoryId)
        {
            var bookingUnits = _dbContext.BookingUnit.AsNoTracking()
                .Include(b => b.Bookings)
                .Select(b => new BookingUnitQueryResultDto
                {
                    Id = b.BookingUnitId,
                    BookingUnitName = b.Name,
                    IsBookingUnitActive = b.IsActive,
                    AdvancePayment = b.Deposit,
                    Fee = b.Price,
                    ReservationLimit = b.MaxBookingDuration,
                    CategoryId = b.Category.CategoryId,
                    BookingIds = b.Bookings.Select(x => x.BookingId).ToList(),
                    RowVersion = b.RowVersion,
                })
                .Where(b => b.CategoryId == categoryId)
                .ToList();
            return bookingUnits;
        }

    }
}
