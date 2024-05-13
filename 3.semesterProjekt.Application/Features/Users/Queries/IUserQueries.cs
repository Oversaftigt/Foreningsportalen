using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Queries
{
    public interface IUserQueries
    {
        Task<IEnumerable<UserQueryDto>> GetUserByUnionId(Guid unionId);
        Task<UserQueryDto> GetUserById(Guid userId);
    }
}
