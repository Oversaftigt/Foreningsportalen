using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Queries
{
    public interface IUserQuery
    {
        Task<IEnumerable<UserDto>> GetUserByUnionId(Guid unionId);
        Task<UserDto> GetUserById(Guid userId);

    }

    public class UserDto
    {
    }
}
