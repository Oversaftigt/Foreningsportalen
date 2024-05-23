using ForeningsPortalen.Website.DTOs.Union;

namespace ForeningsPortalen.WebApp.Contract.Proxy_s
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
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5256/api/Union");
            
            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var unions = await response.Content.ReadFromJsonAsync<IEnumerable<UnionQueryResultDto>>();
            if (unions is null)
            {
                throw new Exception("Unions not found");
            }
            return unions;

        }

        //async Task<IEnumerable<BmiQueryResultDto>?> ILevSundtService.GetAll(string userId)
        //{
        //    return await _httpClient.GetFromJsonAsync<IEnumerable<BmiQueryResultDto>>($"api/Bmi/{userId}");
        //}
    }
}
