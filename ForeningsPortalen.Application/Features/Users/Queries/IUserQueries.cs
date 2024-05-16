using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Queries
{
    public interface IUserQueries
    {
        Task<IEnumerable<UserQueryDto>> GetUserByUnionId(Guid unionId);
        Task<UserQueryDto> GetUserById(Guid userId);
    }

    public class UserQueryDto
    {
    }
}
