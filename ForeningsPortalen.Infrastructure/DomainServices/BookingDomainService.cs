using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.DomainServices
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly ForeningsPortalenContext _dbContext;

        public BookingDomainService(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromAddress(Guid addressId)
        {
            

            var otherBookingsOnThisAddress = _dbContext.Bookings
                                .Where(x => x.User.Address.AddressId == addressId);

            return otherBookingsOnThisAddress;

        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromUnion(Booking booking)
        {
            Guid unionId = _dbContext.Bookings
                            .Where(x => x.BookingId == booking.BookingId)
                            .Select(x => x.User.Address.Union.UnionId)
                            .First();

            var otherBookingsOnThisUnion = _dbContext.Bookings
                                            .Include(x => x.User)
                                            .ThenInclude(x => x.Address)
                                            .Where(x => x.User.Address.Union.UnionId == unionId && x.BookingId != booking.BookingId);

            return otherBookingsOnThisUnion;
        }
    }
}
