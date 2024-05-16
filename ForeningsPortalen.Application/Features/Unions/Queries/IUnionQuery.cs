using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQuery
    {
        UnionQueryResultDto GetUnionWithId(Guid id);
        UnionQueryResultDto GetAllUnions();
    }
}
