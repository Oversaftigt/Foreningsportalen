using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands
{
    public interface IMemberCommands
    {
        void CreateUnionMember(MemberCreateRequestDto createRequestDto);
        void UpdateUnionMember(MemberUpdateRequestDto updateRequestDto);
        void DeleteUnionMember(SharedEntityDeleteDto deleteRequestDto);
    }
}
