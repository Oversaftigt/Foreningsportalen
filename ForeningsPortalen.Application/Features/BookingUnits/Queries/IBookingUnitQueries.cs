using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries
{
    public interface IBookingUnitQueries
    {
        List<BookingUnitQueryResultDto> GetAllBookingUnits();
        List<BookingUnitQueryResultDto> GetBookingUnitsByCategoryId(Guid categoryId);
        List<BookingUnitQueryResultDto> GetBookingUnitsByBookingId(Guid bookingId);
    }
}
