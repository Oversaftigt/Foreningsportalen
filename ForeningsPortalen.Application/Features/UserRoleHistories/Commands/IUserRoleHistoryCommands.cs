using ForeningsPortalen.Application.Features.UserRoles.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands
{
    public interface IUserRoleHistoryCommands
    {
        void CreateUserRoleHistory(UserRoleCreateRequestDto userRoleCreateRequestDto);
        void UpdateUserRoleHistory(UserRoleUpdateRequestDto userRoleUpdateRequestDto);
        void DeleteUserRoleHistory(SharedEntityDeleteDto deleteDto);
    }
}
