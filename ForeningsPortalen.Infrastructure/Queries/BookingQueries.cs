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

        IEnumerable<BookingQueryResultDto> IBookingQueries.GetAllBookings()
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
                     CategoryName = b.BookingUnits[0].Category.Name,
                     Rowversion = b.RowVersion,
                 });

            if (result == null || !result.Any())
            {
                throw new ArgumentNullException("Booking not found");
            }
            return result;

        }

        BookingQueryResultDto IBookingQueries.GetBookingById(Guid bookingId)
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
                     CategoryName = b.BookingUnits[0].Category.Name,
                     Rowversion = b.RowVersion,
                 })
                 .FirstOrDefault(b => b.Id == bookingId);

            if (result == null)
            {
                throw new ArgumentNullException("Booking not found");
            }
            return result;
        }

        IEnumerable<BookingQueryResultDto> IBookingQueries.GetAllBookingsByMember(Guid memberId)
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
                     CategoryName = b.BookingUnits[0].Category.Name,
                     Rowversion = b.RowVersion,
                 })
                 .Where(b => b.UserId == memberId && b.EndTime > DateTime.Now); //Excludes bookings from the past

            if (result == null || !result.Any())
            {
                throw new ArgumentNullException("Booking not found");
            }
            return result;
        }

        IEnumerable<BookingQueryResultDto> IBookingQueries.GetAllBookingsByAddress(Guid addressId)
        {
            var membersOnThisAddress = _dbContext.Bookings.AsNoTracking()
                    .Include(b => b.User)
                    .ThenInclude(b => b.Address)
                    .Where(b => b.User.Address.AddressId == addressId)
                    .Select(b => b.User.UserId);

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
                     CategoryName = b.BookingUnits[0].Category.Name,
                     Rowversion = b.RowVersion,
                 })
                 .Where(b => membersOnThisAddress.Contains(b.UserId) && b.EndTime > DateTime.Now); //Excludes bookings from the past

            if (result == null || !result.Any())
            {
                throw new ArgumentNullException("Booking not found");
            }
            return result;
        }
    }
}
