using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }
    }
}
