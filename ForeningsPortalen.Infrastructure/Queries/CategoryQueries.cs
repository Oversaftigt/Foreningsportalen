using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class CategoryQueries : ICategoryQueries
    {
        public IEnumerable<CategoryQueryResultDto> GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
