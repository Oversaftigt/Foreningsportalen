using ForeningsPortalen.Application.Features.Users.Queries;
using ForeningsPortalen.Application.Features.Users.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UserQueries : IUserQueries
    {
        UserQueryResultDto IUserQueries.GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserQueryResultDto> IUserQueries.GetUserByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }
    }
}
