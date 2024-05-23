using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User user, byte[] rowVersion);
        void UpdateUser(User user, byte[] rowVersion);
        User GetUser(Guid id);

    }
}
