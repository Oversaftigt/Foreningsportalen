using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Commands
{
    public interface IUnionMemberCommands
    {
        void CreateUnionMember(UnionMemberCreateRequestDto createRequestDto);
        void UpdateUnionMember(UnionMemberUpdateRequestDto updateRequestDto);
        void DeleteUnionMember(UnionMemberDeleteRequestDto deleteRequestDto);
    }
}
