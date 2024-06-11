using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.BookingUnit;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class BookingUnitService : IBookingUnitService
    {
        private readonly HttpClient _httpclient;
        private readonly ILogger<BookingUnitService> _logger;

        public BookingUnitService(IHttpClientFactory httpClientFactory, ILogger<BookingUnitService> logger)
        {
            _httpclient = httpClientFactory.CreateClient("ApiClient");
            _logger = logger;
        }

        async Task<IEnumerable<BookingUnitQueryResultDto>> IBookingUnitService.GetAllBookingUnitsOfCategory(Guid categoryId)
        {
            try
            {
                var response = await _httpclient.GetFromJsonAsync<IEnumerable<BookingUnitQueryResultDto>>($"{_httpclient.BaseAddress}api/BookingUnit/category/{categoryId}/bookingUnit");
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        async Task<IEnumerable<DateTime>> IBookingUnitService.GetAvailableDatesForBookingUnit(Guid bookingUnitId)
        {
            try
            {
                var response = await _httpclient.GetFromJsonAsync<IEnumerable<DateTime>>($"{_httpclient.BaseAddress}api/BookingUnit/bookingUnit/{bookingUnitId}/availableTimes");
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        async Task<BookingUnitQueryResultDto> IBookingUnitService.GetBookingUnitById(Guid id)
        {
            try
            {
                var response = await _httpclient.GetFromJsonAsync<BookingUnitQueryResultDto>($"{_httpclient.BaseAddress}api/BookingUnit/{id}");
                return response;
            } 
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }
    }
}