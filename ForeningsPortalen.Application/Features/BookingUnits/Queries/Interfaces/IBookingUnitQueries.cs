using ForeningsPortalen.Application.Features.BookingUnits.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.BookingUnits.Queries.Interfaces
{
    public interface IBookingUnitQueries
    {
        IEnumerable<BookingUnitQueryResultDto> GetAllBookingUnits();
        IEnumerable<BookingUnitQueryResultDto> GetBookingUnitsByCategoryId(Guid categoryId);
        IEnumerable<BookingUnitQueryResultDto> GetBookingUnitsByBookingId(Guid bookingId);
    }
}
