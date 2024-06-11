using ForeningsPortalen.Application.Features.BookingUnits.Queries;
using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Domain.Helpers;
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
            if (bookingUnits is null)
            {
                throw new ArgumentNullException("Error finding booking units");
            }

            return bookingUnits;
        }

        //Hardcoded til at finde tidspunkter for x antal dage frem. Dette virker kun lige for dagsbooking og ikke timebookings. 
        //List<DateTime> IBookingUnitQueries.GetAvailableTimesForBookingUnit(Guid bookingUnitId)
        //{
        //    DateTime startDate = DateTime.Now.Date;
        //    DateTime endDate = startDate.AddDays(30);

        //    var bookingUnit = _dbContext.BookingUnit
        //                                .Include(bu => bu.Category)
        //                                .FirstOrDefault(bu => bu.BookingUnitId == bookingUnitId) ?? throw new Exception("BookingUnit not found");

        //    var bookingsWithThisBookingUnit = _dbContext.Bookings
        //                                                .Where(b => b.BookingUnits.Any(bu => bu.BookingUnitId == bookingUnitId) &&
        //                                                b.BookingStart < endDate &&
        //                                                b.BookingEnd > startDate).ToList();

        //    List<DateTime> availableDates = new();

        //    for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
        //    {
        //        bool IsDateAvailable = true;

        //        foreach (var booking in bookingsWithThisBookingUnit)
        //        {
        //            if (date >= booking.BookingStart && date < booking.BookingEnd)
        //            {
        //                IsDateAvailable = false;
        //                break;
        //            }
        //        }
        //        if (IsDateAvailable is true)
        //            availableDates.Add(date);
        //    }

        //    return availableDates;

        //}
        public List<DateTime> GetAvailableTimesForBookingUnit(Guid bookingUnitId)
        {
            DateTime startDate = DateTime.Now.Date;
            DateTime endDate = startDate.AddDays(30);

            var bookingUnit = _dbContext.BookingUnit
                                        .Include(bu => bu.Category)
                                        .FirstOrDefault(bu => bu.BookingUnitId == bookingUnitId) ?? throw new Exception("BookingUnit not found");

            var bookingsWithThisBookingUnit = _dbContext.Bookings
                                                        .Where(b => b.BookingUnits.Any(bu => bu.BookingUnitId == bookingUnitId) &&
                                                                    b.BookingStart < endDate &&
                                                                    b.BookingEnd > startDate)
                                                        .ToList();

            List<DateTime> availableTimes = new();

            TimeSpan increment = bookingUnit.Category.DurationType == BookingDurationType.Days ? TimeSpan.FromDays(1) : TimeSpan.FromHours(bookingUnit.MaxBookingDuration);

            for (DateTime dateTime = startDate; dateTime <= endDate; dateTime += increment)
            {
                bool isTimeAvailable = true;

                foreach (var booking in bookingsWithThisBookingUnit)
                {
                    if (dateTime >= booking.BookingStart && dateTime < booking.BookingEnd)
                    {
                        isTimeAvailable = false;
                        break;
                    }
                }
                //excludes times that overlap with the actual current time
                if (dateTime <= DateTime.Now)
                {
                    isTimeAvailable = false;
                    
                }

                if (isTimeAvailable)
                    availableTimes.Add(dateTime);
            }

            return availableTimes;
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

            if (bookingUnits is null)
            {
                throw new ArgumentNullException("Error finding booking units for this category");
            }

            return bookingUnits;
        }

        BookingUnitQueryResultDto IBookingUnitQueries.GetBookingUnitById(Guid id)
        {
            var bookingUnit = _dbContext.BookingUnit.AsNoTracking()
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
                .Where(b => b.Id == id)
                .FirstOrDefault();

            if (bookingUnit is null)
            {
                throw new ArgumentNullException("Error finding booking unit");
            }

            return bookingUnit;
        }
    }
}
