using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQueries
    {
        UnionQueryResultDto GelOneUnionById(Guid id);
        UnionQueryResultDto GelAllUnions();
    }
}
