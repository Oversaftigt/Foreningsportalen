using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands
{
    public interface IUserRoleHistoryCommands
    {
        /// <summary>
        /// Create a new userRole history
        /// </summary>
        /// <param name="userRoleCreateRequestDto"></param>
        void CreateUserRoleHistory(UserRoleHistoryCreateRequestDto userRoleCreateRequestDto);

        /// <summary>
        /// Update an existing userRole history
        /// </summary>
        /// <param name="userRoleUpdateRequestDto"></param>
        void UpdateUserRoleHistory(UserRoleHistoryUpdateRequestDto userRoleUpdateRequestDto);

        /// <summary>
        /// Delete userRole history
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteUserRoleHistory(SharedEntityDeleteDto deleteDto);
    }
}
