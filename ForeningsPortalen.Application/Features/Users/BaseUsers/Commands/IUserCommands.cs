using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands
{
    public interface IUserCommands
    {
        void CreateUser(UserCreateRequestDto userCreateDto);
        void UpdateUser(UserUpdateRequestDto userEditDto);
        void DeleteUser(UserDeleteRequestDto userDeleteDto);
    }

}
