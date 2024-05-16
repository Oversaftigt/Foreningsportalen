using ForeningsPortalen.Application.Features.Users.UnionMembers.Repositories;
using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UnionMemberRepository : IUnionMemberRepository
    {
        void IUnionMemberRepository.CreateUnionMember(UnionMember unionMember)
        {
            throw new NotImplementedException();
        }

        void IUnionMemberRepository.DeleteUnionMember(UnionMember unionMember, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        UnionMember IUnionMemberRepository.GetUnionMember(Guid unionMemberId)
        {
            throw new NotImplementedException();
        }

        void IUnionMemberRepository.UpdateUnionMember(UnionMember unionMember, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
