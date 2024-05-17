using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Queries.Interfaces
{
    public interface ICategoryQueries
    {
        IEnumerable<CategoryQueryResultDto> GetCategories();
    }
}
