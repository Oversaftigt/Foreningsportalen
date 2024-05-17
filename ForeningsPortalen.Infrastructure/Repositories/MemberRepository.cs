using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        void IMemberRepository.CreateUnionMember(Member unionMember)
        {
            throw new NotImplementedException();
        }

        void IMemberRepository.DeleteUnionMember(Member unionMember, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        Member IMemberRepository.GetUnionMember(Guid unionMemberId)
        {
            throw new NotImplementedException();
        }

        void IMemberRepository.UpdateUnionMember(Member unionMember, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
