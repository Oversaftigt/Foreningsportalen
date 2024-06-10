using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface ICategoryService
    {
        Task PostCategoryAsync(CategoryCreateRequestDto categoryCreateRequest);

        Task<IEnumerable<CategoryQueryResultDto>> GetCategoriesAsync(Guid unionId);

        Task<CategoryQueryResultDto> GetCategoriesById(Guid categoryId);
    }
}
