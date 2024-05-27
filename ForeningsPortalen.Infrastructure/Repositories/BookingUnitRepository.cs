using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class BookingUnitRepository : IBookingUnitRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BookingUnitRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IBookingUnitRepository.AddBookingUnit(BookingUnit bookingUnit)
        {
            _dbContext.Add(bookingUnit);
            _dbContext.SaveChanges();
        }

        void IBookingUnitRepository.DeleteBookingUnit(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }

        BookingUnit IBookingUnitRepository.GetBookingUnit(Guid id)
        {
            var bookingUnit = _dbContext.BookingUnit
                                        .Include(x => x.Category)
                                        .FirstOrDefault(x => x.BookingUnitId == id);

            if (bookingUnit == null)
            {
                throw new ArgumentNullException("bookingunit not found");
            }

            return bookingUnit;
        }

        void IBookingUnitRepository.UpdateBookingUnit(BookingUnit bookingUnit)
        {
            throw new NotImplementedException();
        }
    }
}
