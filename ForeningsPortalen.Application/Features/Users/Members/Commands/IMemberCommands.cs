using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands
{
    public interface IMemberCommands
    {
        /// <summary>
        /// Create a new member
        /// </summary>
        /// <param name="createRequestDto"></param>
        void CreateUnionMember(MemberCreateRequestDto createRequestDto);,

        /// <summary>
        /// Update an existing member
        /// </summary>
        /// <param name="updateRequestDto"></param>
        void UpdateUnionMember(MemberUpdateRequestDto updateRequestDto);

        /// <summary>
        /// Delete a member
        /// </summary>
        /// <param name="deleteRequestDto"></param>
        void DeleteUnionMember(SharedEntityDeleteDto deleteRequestDto);
    }
}
