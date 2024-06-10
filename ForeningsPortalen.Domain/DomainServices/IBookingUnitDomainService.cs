using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IBookingUnitDomainService
    {
        /// <summary>
        /// Gets a list of bookingsunits from the union, based on the Id
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<BookingUnit> OtherBookingUnitsFromUnion(Guid unionId);
    }
}
