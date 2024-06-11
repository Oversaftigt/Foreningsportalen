using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRoleRepository
    {
        /// <summary>
        /// Add a new userRole in the database
        /// </summary>
        /// <param name="userRole"></param>
        void AddUserRole(UserRoleHistory userRole);

        /// <summary>
        /// Delete a userRole in the database
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="rowVersion"></param>
        void DeleteUserRole(UserRoleHistory userRole, byte[] rowVersion);

        /// <summary>
        /// Update an existing userRole in the database
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="rowVersion"></param>
        void UpdateUserRole(UserRoleHistory userRole, byte[] rowVersion);

        /// <summary>
        /// Get a userRole in the database by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserRoleHistory GetUserRole(Guid id);
    }
}