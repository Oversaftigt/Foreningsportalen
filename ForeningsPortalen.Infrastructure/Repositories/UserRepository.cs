using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public UserRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }
        void IUserRepository.AddUser(User user)
        {
            _dbContext.Add(user);
            _dbContext.SaveChanges();
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
