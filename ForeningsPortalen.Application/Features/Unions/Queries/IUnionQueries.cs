using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQueries
    {
        UnionQueryResultDto GelOneUnionById(Guid id);
        UnionQueryResultDto GelAllUnions();
    }
}
