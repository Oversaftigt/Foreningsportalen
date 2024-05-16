using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.UnionMembers.Queries
{
    public interface IUnionMemberQueries
    {
        UnionMemberQueryResultDto GetUnionMemberByUserId(Guid id);
        List<UnionMemberQueryResultDto> GetUnionMembersByUnion(Guid unionId);
    }
}
