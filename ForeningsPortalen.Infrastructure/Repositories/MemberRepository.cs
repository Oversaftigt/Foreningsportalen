using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly ForeningsPortalenContext _db;
        public MemberRepository(ForeningsPortalenContext foreningsPortalenContext)
        {
            _db = foreningsPortalenContext;
        }
        void IMemberRepository.CreateUnionMember(Member unionMember)
        {
            _db.Add(unionMember);
            _db.SaveChanges();
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
