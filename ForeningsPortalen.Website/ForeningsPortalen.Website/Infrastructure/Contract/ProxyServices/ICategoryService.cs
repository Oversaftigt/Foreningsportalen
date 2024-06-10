using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface ICategoryService
    {
        /// <summary>
        /// Create a new category
        /// </summary>
        /// <param name="categoryCreateRequest"></param>
        /// <returns></returns>
        Task PostCategoryAsync(CategoryCreateRequestDto categoryCreateRequest);

        /// <summary>
        /// Get a list of all the categories in a specific union, using union ID
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        Task<IEnumerable<CategoryQueryResultDto>> GetCategoriesAsync(Guid unionId);


    }
}
