using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
