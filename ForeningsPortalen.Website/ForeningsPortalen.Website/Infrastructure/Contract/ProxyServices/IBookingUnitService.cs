using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.BookingUnit;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IBookingUnitService
    {
        Task<IEnumerable<BookingUnitQueryResultDto>> GetAllBookingUnitsOfCategory(Guid categoryId);

    }
}
