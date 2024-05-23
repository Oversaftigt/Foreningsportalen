using ForeningsPortalen.Application.Features.Roles.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Commands
{
    public interface IRoleCommands
    {
        void CreateRoles(RoleCreateRequestDto roleCreateRequestDto);
        void UpdateRoles(RoleUpdateRequestDto roleUpdateRequestDto);
        void DeleteRoles(SharedEntityDeleteDto deleteDto);
    }
}
