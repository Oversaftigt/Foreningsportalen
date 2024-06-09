using ForeningsPortalen.Application.Features.UserRoleHistories.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.UserRoleHistories.Queries
{
    public interface IUserRoleHistoryQueries
    {
        /// <summary>
        /// Get specific userRole history, by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserRoleHistoryCreateRequestDto GetUserRoleHistory(Guid id);

        /// <summary>
        /// Get a list of all UserRoleHistories
        /// </summary>
        /// <returns></returns>
        List<UserRoleHistoryCreateRequestDto> GetAlleUserRoleHistories();
    }
}
