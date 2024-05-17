using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IMemberRepository
    {
        void CreateUnionMember(Member unionMember);
        void UpdateUnionMember(Member unionMember, byte[] rowVersion);
        void DeleteUnionMember(Member unionMember, byte[] rowVersion);
        Member GetUnionMember(Guid unionMemberId);
    }
}
