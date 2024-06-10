using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.BookingUnit;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IBookingUnitService
    {
        /// <summary>
        /// Gets a list of all the bookingUnits of a specific category, using the category Id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        Task<IEnumerable<BookingUnitQueryResultDto>> GetAllBookingUnitsOfCategory(Guid categoryId);

        /// <summary>
        /// Gets a list of dates, where the bookingUnit is free to book, using bookingUnitId
        /// </summary>
        /// <param name="bookingUnitId"></param>
        /// <returns></returns>
        Task<IEnumerable<DateTime>> GetAvailableDatesForBookingUnit(Guid bookingUnitId);
    }
}
