using ForeningsPortalen.Application.Features.Categories.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Queries.Interfaces
{
    public interface ICategoryQueries
    {
        IEnumerable<CategoryQueryResultDto> GetCategories();
    }
}
