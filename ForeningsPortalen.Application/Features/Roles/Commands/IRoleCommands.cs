using ForeningsPortalen.Application.Features.Roles.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Roles.Commands
{
    public interface IRoleCommands
    {
        void CreateRoles(RoleCreateRequestDto roleCreateRequestDto);
        void UpdateRoles(RoleUpdateRequestDto roleUpdateRequestDto);
        void DeleteRoles(SharedEntityDeleteDto deleteDto);
    }
}
