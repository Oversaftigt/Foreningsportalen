using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Add a new role to the database
        /// </summary>
        /// <param name="role"></param>
        void AddRole(Role role);

        /// <summary>
        /// Update an existing role in the database
        /// </summary>
        /// <param name="role"></param>
        /// <param name="rowversion"></param>
        void UpdateRole(Role role, byte[] rowversion);

        /// <summary>
        /// Delete a role
        /// </summary>
        /// <param name="role"></param>
        /// <param name="rowversion"></param>
        void DeleteRole(Role role, byte[] rowversion);

        /// <summary>
        /// Get a specific role by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Role GetRole(Guid id);
    }
}
