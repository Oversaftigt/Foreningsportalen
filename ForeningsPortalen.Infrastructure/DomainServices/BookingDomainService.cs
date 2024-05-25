using ForeningsPortalen.Domain.DomainServices;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.DomainServices
{
    public class BookingDomainService : IBookingDomainService
    {
        private readonly ForeningsPortalenContext _context;

        public BookingDomainService(ForeningsPortalenContext dbContext)
        {
            _context = dbContext;
        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromAddress(Guid addressId)
        {
            var otherBookingsOnThisAddress = _context.Bookings
                                            .Include(x => x.User)//For eager loading
                                            .ThenInclude(x => x.Address)
                                            .ThenInclude(x => x.Union)
                                            .Include(x => x.BookingUnits)
                                            .ThenInclude(x => x.Category)
                                            .Where(x => x.BookingEnd > DateTime.Now &&
                                                        x.User.Address.AddressId == addressId);

            return otherBookingsOnThisAddress;

        }

        IEnumerable<Booking> IBookingDomainService.OtherBookingsFromUnion(Guid unionId)
        {
            var otherBookingsOnThisUnion = _context.Bookings
                                            .Include(x => x.User)//For eager loading
                                            .ThenInclude(x => x.Address)
                                            .ThenInclude(x => x.Union)
                                            .Include(x => x.BookingUnits)
                                            .ThenInclude(x => x.Category)
                                            .Where(x => x.BookingEnd > DateTime.Now &&
                                                        x.User.Address.Union.UnionId == unionId);

            return otherBookingsOnThisUnion;
        }
    }
}
