using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Domain.DomainServices
{
    public interface IBookingUnitDomainService
    {
        IEnumerable<BookingUnit> OtherBookingUnitsFromUnion(Guid unionId);
    }
}
