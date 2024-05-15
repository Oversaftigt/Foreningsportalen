using _3.semesterProjekt.Application.Features.Users.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.semesterProjekt.Application.Features.Users.Commands
{
    public interface IUserCommands
    {
        void CreateUser(UserCreateRequestDto userCreateDto);
        void UpdateUser(UserUpdateRequestDto userEditDto);
        void DeleteUser(UserDeleteRequestDto userDeleteDto);
    }
}
