using ForeningsPortalen.Application.Features.Users.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Queries
{
    public interface IUserQueries
    {
        IEnumerable<UserQueryResultDto> GetUserByUnionId(Guid unionId);
        UserQueryResultDto GetUserById(Guid userId);
    }
}
