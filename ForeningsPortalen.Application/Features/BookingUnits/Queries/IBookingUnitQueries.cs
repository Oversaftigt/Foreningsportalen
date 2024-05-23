using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries
{
    public interface IBookingUnitQueries
    {
        List<BookingUnit> GetAllBookingUnits();
        List<BookingUnit> GetBookingUnitsByCategoryId(Guid categoryId);
        List<BookingUnit> GetBookingUnitsByBookingId(Guid bookingId);
    }
}
