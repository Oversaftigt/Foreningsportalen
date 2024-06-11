using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking;
using System.Net.Http;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<BookingService> _logger;

        public BookingService(IHttpClientFactory httpClientFactory, ILogger<BookingService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            _logger = logger;
        }

        async Task<IEnumerable<BookingQueryResultDto>> IBookingService.GetBookingByMemberAsync(Guid id)
        {
            try
            {
                var bookings = await _httpClient.GetFromJsonAsync<IEnumerable<BookingQueryResultDto>>($"{_httpClient.BaseAddress}api/booking/member/{id}/booking");
                return bookings;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }
        }

        async Task IBookingService.PostBookingAsync(BookingCreateRequestDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}api/booking", dto);

            if (response.IsSuccessStatusCode) return;

            var message = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Response: {message}");
            throw new Exception(message);
        }
    }
}
