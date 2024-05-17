using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Queries
{
    public interface IMemberQueries
    {
        MemberQueryResultDto GetUnionMemberByUserId(Guid id);
        List<MemberQueryResultDto> GetUnionMembersByUnion(Guid unionId);
    }
}
