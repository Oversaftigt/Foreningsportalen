using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Role;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly HttpClient _httpClient;
        public RoleService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        async Task<IEnumerable<RoleQueryRequestDto>> IRoleService.GetAllRolesAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/role");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var Roles = await response.Content.ReadFromJsonAsync<IEnumerable<RoleQueryRequestDto>>();

            return Roles;
        }
    }
}
