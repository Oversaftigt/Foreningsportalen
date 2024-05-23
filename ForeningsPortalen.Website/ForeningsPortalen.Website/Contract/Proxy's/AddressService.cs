using ForeningsPortalen.Website.DTOs.Address;

namespace ForeningsPortalen.WebApp.Contract
{
    public class AddressService : IAddressService
    {
        private readonly HttpClient _httpClient;
        public AddressService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }
        
        async Task<IEnumerable<AddressQueryResultDto>> IAddressService.GetAllAddressesAsync(Guid unionId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:5256/api/Address/byUnion/{unionId}");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var addresses = await response.Content.ReadFromJsonAsync<IEnumerable<AddressQueryResultDto>>();
            if (addresses is null)
            {
                throw new Exception("Unions not found");
            }
            return addresses;
        }
    }
}