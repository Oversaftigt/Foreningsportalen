using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleHistoryRepository
    {
        /// <summary>
        /// Add a new user role history in the database
        /// </summary>
        /// <param name="userRoleHistory"></param>
        void AddUserRoleHistory(UserRoleHistory userRoleHistory);

        /// <summary>
        /// Delete user role history in the database
        /// </summary>
        /// <param name="userRoleHistory"></param>
        /// <param name="rowVersion"></param>
        void DeleteUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);

        /// <summary>
        /// Update an existing user role history in the database
        /// </summary>
        /// <param name="userRoleHistory"></param>
        /// <param name="rowVersion"></param>
        void UpdateUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion);

        /// <summary>
        /// Get a specific user role history in the database by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserRoleHistory GetUserRoleHistory(Guid id);
    }
}
