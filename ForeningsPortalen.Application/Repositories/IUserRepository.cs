using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        /// Add a new user to the database
        /// </summary>
        /// <param name="user"></param>
        void AddUser(User user);

        /// <summary>
        /// Delete a user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rowVersion"></param>
        void DeleteUser(User user, byte[] rowVersion);

        /// <summary>
        /// Update an existing user in the database
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rowVersion"></param>
        void UpdateUser(User user, byte[] rowVersion);

        /// <summary>
        /// Get a specific user by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        User GetUser(Guid id);

    }
}
