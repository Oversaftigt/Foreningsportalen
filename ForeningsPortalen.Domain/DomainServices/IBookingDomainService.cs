using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IBookingDomainService
    {
        IEnumerable<Booking> OtherBookingsFromUnion(Guid unionId);
        IEnumerable<Booking> OtherBookingsFromAddress(Guid addressId);
    }
}
