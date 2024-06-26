﻿using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.DomainServices
{
    public class BookingUnitDomainService : IBookingUnitDomainService
    {
        private readonly ForeningsPortalenContext _context;

        public BookingUnitDomainService(ForeningsPortalenContext context)
        {
            _context = context;
        }

        IEnumerable<BookingUnit> IBookingUnitDomainService.OtherBookingUnitsFromUnion(Guid unionId)
        {
            var bookingUnits = _context.BookingUnit.Where(x => x.Category.Union.UnionId == unionId);
            return bookingUnits;
        }
    }
}
