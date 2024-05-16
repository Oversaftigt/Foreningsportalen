using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using ForeningsPortalen.Application.Features.Categories.Queries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
