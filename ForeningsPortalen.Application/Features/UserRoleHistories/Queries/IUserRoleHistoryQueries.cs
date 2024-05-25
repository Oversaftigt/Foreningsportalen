using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Queries
{
    public interface IUserRoleHistoryQueries
    {
        UserRoleHistoryCreateRequestDto GetUserRoleHistory(Guid id);
        List<UserRoleHistoryCreateRequestDto> GetAlleUserRoleHistories();
    }
}
