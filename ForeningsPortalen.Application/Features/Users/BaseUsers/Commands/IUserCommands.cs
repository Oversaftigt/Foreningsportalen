using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands
{
    public interface IUserCommands
    {
        void CreateUser(UserCreateRequestDto userCreateDto);
        void UpdateUser(UserUpdateRequestDto userEditDto);
        void DeleteUser(UserDeleteRequestDto userDeleteDto);
    }

}
