using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Commands
{
    public interface IUserCommands
    {
        Task CreateUser(UserCreateRequestDto userCreateDto);
        Task UpdateUser(UserEditRequestDto userEditDto);
        Task DeleteUser(Guid userId);
    }

    public class UserEditRequestDto
    {
    }

    public class UserCreateRequestDto
    {
    }
}
