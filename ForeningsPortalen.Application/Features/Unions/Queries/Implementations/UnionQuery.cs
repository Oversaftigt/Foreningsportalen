using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries.Implementations
{
    public class UnionQuery : IUnionQuery
    {
        private readonly IUnionQueries _Queries;
        public UnionQuery(IUnionQueries queries)
        {
            _Queries = queries;
        }

        List<UnionQueryResultDto> IUnionQuery.GetAllUnions()
        {
            throw new NotImplementedException();
        }

        UnionQueryResultDto IUnionQuery.GetUnionWithId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
