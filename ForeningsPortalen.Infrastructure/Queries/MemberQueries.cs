using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class MemberQueries : IMemberQueries
    {
        MemberQueryResultDto IMemberQueries.GetUnionMemberByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        List<MemberQueryResultDto> IMemberQueries.GetUnionMembersByUnion(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
