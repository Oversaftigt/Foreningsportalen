using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UnionMemberQueries : IUnionMemberQueries
    {
        UnionMemberQueryResultDto IUnionMemberQueries.GetUnionMemberByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        List<UnionMemberQueryResultDto> IUnionMemberQueries.GetUnionMembersByUnion(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
