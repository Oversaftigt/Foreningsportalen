using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(IHttpClientFactory httpClientFactory, ILogger<CategoryService> logger)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            _logger = logger;
        }

        async Task ICategoryService.PostCategoryAsync(CategoryCreateRequestDto categoryCreateRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_httpClient.BaseAddress}api/category", categoryCreateRequest);

            if (response.IsSuccessStatusCode) return;
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception(message);
        }

        async Task<IEnumerable<CategoryQueryResultDto>> ICategoryService.GetCategoriesAsync(Guid unionId)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<IEnumerable<CategoryQueryResultDto>>($"{_httpClient.BaseAddress}api/category/categories/ByUnion/{unionId}");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return null;
            }

            ////var request = new HttpRequestMessage(HttpMethod.Get, $"{_httpClient.BaseAddress}api/category/categories/ByUnion/{unionId}");

            //var response = await _httpClient.SendAsync(request);
            //response.EnsureSuccessStatusCode();


            //var categories = await response.Content.ReadFromJsonAsync<IEnumerable<CategoryQueryResultDto>>();

            //return categories;
        }
    }
}
