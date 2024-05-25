using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Queries
{
    public interface ICategoryQueries
    {
        IEnumerable<CategoryQueryResultDto> GetCategories();
        CategoryQueryResultDto GetCategory(Guid id);
    }
}
