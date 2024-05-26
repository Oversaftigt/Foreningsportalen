using Azure.Core;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class UnionService : IUnionService
    {
        private readonly HttpClient _httpClient;
        public UnionService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        async Task<IEnumerable<UnionQueryResultDto>> IUnionService.GetAllUnionsAsync()
        {
            var url = $"{(_httpClient.BaseAddress.ToString())}/api/union";
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/union");
            var response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            var unions = await response.Content.ReadFromJsonAsync<IEnumerable<UnionQueryResultDto>>();

            return unions ?? new List<UnionQueryResultDto>();
        }

        async Task IUnionService.PostUnionAsync(UnionCreateRequestDto unionCreateRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}api/union", unionCreateRequest);

            if (response.IsSuccessStatusCode) return;
            throw new Exception("Creating a union failed");
        }



        //async Task<IEnumerable<BmiQueryResultDto>?> ILevSundtService.GetAll(string userId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<BmiQueryResultDto>>($"api/Bmi/{userId}");
        //}
    }
}
