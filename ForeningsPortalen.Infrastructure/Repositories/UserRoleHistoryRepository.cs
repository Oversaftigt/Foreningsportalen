using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UserRoleHistoryRepository : IUserRoleHistoryRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public UserRoleHistoryRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IUserRoleHistoryRepository.AddUserRoleHistory(UserRoleHistory userRoleHistory)
        {
            _dbContext.Add(userRoleHistory);
            _dbContext.SaveChanges();
        }

        void IUserRoleHistoryRepository.DeleteUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        UserRoleHistory IUserRoleHistoryRepository.GetUserRoleHistory(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUserRoleHistoryRepository.UpdateUserRoleHistory(UserRoleHistory userRoleHistory, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
