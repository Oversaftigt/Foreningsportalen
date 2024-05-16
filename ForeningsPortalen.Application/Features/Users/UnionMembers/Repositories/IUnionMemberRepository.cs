using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Repositories
{
    public  interface IUnionMemberRepository
    {
        void CreateUnionMember(UnionMember unionMember);
        void UpdateUnionMember(UnionMember unionMember, byte[] rowVersion);
        void DeleteUnionMember(UnionMember unionMember, byte[] rowVersion);
        UnionMember GetUnionMember(Guid unionMemberId);
    }
}
