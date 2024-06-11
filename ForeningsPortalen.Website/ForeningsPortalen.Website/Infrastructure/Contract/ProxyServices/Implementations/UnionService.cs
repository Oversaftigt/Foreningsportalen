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

        async Task IUnionService.PutUnionAsync(UnionUpdateRequestDto unionUpdateRequest)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_httpClient.BaseAddress}api/union/{unionUpdateRequest.id}", unionUpdateRequest);

            if (response.IsSuccessStatusCode) return;
            throw new Exception("Updating union failed");
        }

        async Task<UnionQueryResultDto> IUnionService.GetUnionByIdAsync(Guid id)
        {
            var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}api/union/{id}");

            response.EnsureSuccessStatusCode();

            var union = await response.Content.ReadFromJsonAsync<UnionQueryResultDto>();

            return union ?? throw new Exception("Union not found");
        }

    }
}
