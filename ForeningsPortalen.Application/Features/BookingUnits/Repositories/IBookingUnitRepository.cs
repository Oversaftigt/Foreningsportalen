using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Repositories
{
    public interface IBookingUnitRepository
    {
        void AddBookingUnit(BookingUnit BookingUnit);
        BookingUnit GetBookingUnit(Guid id);
        void UpdateBookingUnit(BookingUnit BookingUnit, byte[] rowVersion);
        void DeleteBookingUnit(BookingUnit BookingUnit, byte[] rowVersion);
    }
}
