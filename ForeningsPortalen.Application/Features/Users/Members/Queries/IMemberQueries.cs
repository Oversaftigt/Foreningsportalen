using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Queries
{
    public interface IMemberQueries
    {
        /// <summary>
        /// Get a specific user, by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MemberQueryResultDto GetUnionMemberByUserId(Guid id);

        /// <summary>
        /// Get a list of members, belonging to a specific union, using unionId
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        IEnumerable<MemberQueryResultDto> GetUnionMembersByUnion(Guid unionId);
    }
}
