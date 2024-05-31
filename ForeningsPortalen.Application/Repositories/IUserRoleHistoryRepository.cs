using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleHistoryRepository
    {
        void AddUserRoleHistory(UserRoleHistory userRoleHistory);
        void DeleteUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);
        void UpdateUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);
        UserRoleHistory GetUserRoleHistory(Guid id);
    }
}
