using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Unions.Queries.Implementations
{
    public class UnionQuery : IUnionQuery
    {
        private readonly IUnionQueries _Queries;
        public UnionQuery(IUnionQueries queries)
        {
            _Queries = queries;
        }

       List< UnionQueryResultDto> IUnionQuery.GetAllUnions()
        {
            throw new NotImplementedException();
        }

        UnionQueryResultDto IUnionQuery.GetUnionWithId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
