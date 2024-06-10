using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Queries
{
    public interface ICategoryQueries
    {
        /// <summary>
        /// Get all categories in an union, using union Id
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<CategoryQueryResultDto> GetCategoriesByUnionId(Guid unionId);

        /// <summary>
        /// Get all categories in the database
        /// </summary>
        /// <returns></returns>
        IEnumerable<CategoryQueryResultDto> GetCategories();

        /// <summary>
        /// Get a specific category, using category id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CategoryQueryResultDto GetCategory(Guid id);
    }
}
