using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IBookingDomainService
    {
        /// <summary>
        /// Gets a list of bookings in the union, using unionID
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<Booking> OtherBookingsFromUnion(Guid unionId);

        /// <summary>
        /// Gets a list of bookings based on the address, using the address Id
        /// </summary>
        /// <param name="addressId"></param>
        /// <returns></returns>
        IEnumerable<Booking> OtherBookingsFromAddress(Guid addressId);
    }
}
