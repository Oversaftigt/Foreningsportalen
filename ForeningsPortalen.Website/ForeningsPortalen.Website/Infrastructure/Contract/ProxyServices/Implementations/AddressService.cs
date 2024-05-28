using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Address;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;
        public AddressService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        async Task<AddressQueryResultDto> IAddressService.GetAddressAsync(Guid addressId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/address{addressId}");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var address = await response.Content.ReadFromJsonAsync<AddressQueryResultDto>();

            return address;
        }

        //async Task<BmiQueryResultDto?> ILevSundtService.Get(int id, string userId)
        //{
        //}

        //async Task<IEnumerable<BmiQueryResultDto>?> ILevSundtService.GetAll(string userId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<BmiQueryResultDto>>($"api/Bmi/{userId}");
        //}
        async Task<IEnumerable<AddressQueryResultDto>> IAddressService.GetAllAddressesAsync(Guid unionId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/address/union/{unionId}/address");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var addresses = await response.Content.ReadFromJsonAsync<IEnumerable<AddressQueryResultDto>>();

            return addresses;
        }

        async Task IAddressService.PostAddressAsync(AddressCreateRequestDto addressCreateRequestDto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}api/address", addressCreateRequestDto);

            if (response.IsSuccessStatusCode) return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }
    }
}