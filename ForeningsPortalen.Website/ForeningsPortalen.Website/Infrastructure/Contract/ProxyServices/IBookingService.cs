using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingQueryResultDto>> GetBookingByMemberAsync(Guid id);
        Task PostBookingAsync(BookingCreateRequestDto dto);
    }
}
