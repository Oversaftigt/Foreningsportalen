using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.semesterProjekt.Application.Features.Users.Queries.DTOs;

namespace _3.semesterProjekt.Application.Features.Users.Queries
{
    public interface IUserQueries
    {
        IEnumerable<UserQueryResultDto> GetUserByUnionId(Guid unionId);
        UserQueryResultDto GetUserById(Guid userId);
    }
}
