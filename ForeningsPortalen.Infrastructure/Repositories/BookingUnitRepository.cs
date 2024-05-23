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
    public class BookingUnitRepository : IBookingUnitRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public BookingUnitRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IBookingUnitRepository.AddBookingUnit(BookingUnit BookingUnit)
        {
            throw new NotImplementedException();
        }

        void IBookingUnitRepository.DeleteBookingUnit(BookingUnit BookingUnit, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        List<BookingUnit> IBookingUnitRepository.GetAll()
        {
          var bookingUnits = _dbContext.BookingUnit.ToList();
            return bookingUnits;
        }

        BookingUnit IBookingUnitRepository.GetBookingUnit(Guid id)
        {
            throw new NotImplementedException();
        }

        void IBookingUnitRepository.UpdateBookingUnit(BookingUnit BookingUnit, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
