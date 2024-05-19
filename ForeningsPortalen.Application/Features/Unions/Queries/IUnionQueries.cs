using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQueries
    {
        UnionQueryResultDto GetUnionById(Guid id);
        IEnumerable<UnionQueryResultDto> GetAllUnions();
    }
}
