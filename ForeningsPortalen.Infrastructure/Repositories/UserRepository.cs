using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    internal class UserRepository : IUserRepository
    {
        //Inject db context
        public UserRepository()
        {
            //var _db;
        }
        void IUserRepository.AddUser(User user)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.DeleteUser(User booking, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.UpdateUser(User user, byte[] rowVersion)
        {

            //_db.Entry(user).Property(p => p.RowVersion).OriginalValue = rowVersion;
        }
    }
}
