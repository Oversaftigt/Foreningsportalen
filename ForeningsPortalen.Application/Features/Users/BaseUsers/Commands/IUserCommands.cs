using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.Users.BaseUsers.Commands
{
    public interface IUserCommands
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="userCreateDto"></param>
        void CreateUser(UserCreateRequestDto userCreateDto);
        
        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name="userEditDto"></param>
        void UpdateUser(UserUpdateRequestDto userEditDto);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="userDeleteDto"></param>
        void DeleteUser(UserDeleteRequestDto userDeleteDto);
    }

}
