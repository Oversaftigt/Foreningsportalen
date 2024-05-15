using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Union.Queries.Implementations
{
    public class UnionQuery : IUnionQuery
    {
        private readonly IUnionQueries _Queries;
        public UnionQuery(IUnionQueries queries)
        {
            _Queries = queries;
        }
    }
}
