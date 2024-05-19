using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class MemberQueries : IMemberQueries
    {
        private readonly ForeningsPortalenContext _db;
        public MemberQueries(ForeningsPortalenContext foreningsPortalenContext)
        {
            _db = foreningsPortalenContext;
        }
        MemberQueryResultDto IMemberQueries.GetUnionMemberByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<MemberQueryResultDto> IMemberQueries.GetUnionMembersByUnion(Guid unionId)
        {
            var members = _db.Members.AsNoTracking()
                          .Select(a => new MemberQueryResultDto()
                          {
                              Id = a.UserId,
                              UnionId = a.Address.Union.UnionId,
                              FirstName = a.FirstName,
                              LastName = a.LastName,
                              Email = a.Email,
                              PhoneNumber = a.PhoneNumber,
                              MoveInDate = a.MoveInDate,
                              MoveOutDate = a.MoveOutDate,
                              CurrentAddress = a.Address,
                              RowVersion = a.RowVersion,
                          })
                          .Where(a => a.UnionId == unionId).ToList();

            if (!members.Any())
            {
                throw new Exception("No members were found");
            }

            return members;
        }
    }
}
