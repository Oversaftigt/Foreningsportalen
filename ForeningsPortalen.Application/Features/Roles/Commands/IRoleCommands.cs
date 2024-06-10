using ForeningsPortalen.Application.Features.Roles.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Roles.Commands
{
    public interface IRoleCommands
    {
        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="roleCreateRequestDto"></param>
        void CreateRoles(RoleCreateRequestDto roleCreateRequestDto);

        /// <summary>
        /// Update an existing role
        /// </summary>
        /// <param name="roleUpdateRequestDto"></param>
        void UpdateRoles(RoleUpdateRequestDto roleUpdateRequestDto);

        /// <summary>
        /// Delete an existing role
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteRoles(SharedEntityDeleteDto deleteDto);
    }
}
