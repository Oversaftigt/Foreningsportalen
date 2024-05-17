using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;

namespace ForeningsPortalen.Application.Features.Categories.Queries.Implementations
{
    public class CategoryQueries : ICategoryQueries
    {

        IEnumerable<CategoryQueryResultDto> ICategoryQueries.GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
