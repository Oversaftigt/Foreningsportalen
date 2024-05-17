using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Queries
{
    public interface IUnionQuery
    {
        UnionQueryResultDto GetUnionWithId(Guid id);
        List<UnionQueryResultDto> GetAllUnions();
    }
}
