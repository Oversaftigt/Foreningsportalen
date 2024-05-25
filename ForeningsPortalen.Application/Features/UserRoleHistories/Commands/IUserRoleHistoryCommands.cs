using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Commands
{
    public interface IUserRoleHistoryCommands
    {
        void CreateUserRoleHistory(UserRoleHistoryCreateRequestDto userRoleCreateRequestDto);
        void UpdateUserRoleHistory(UserRoleHistoryUpdateRequestDto userRoleUpdateRequestDto);
        void DeleteUserRoleHistory(SharedEntityDeleteDto deleteDto);
    }
}
