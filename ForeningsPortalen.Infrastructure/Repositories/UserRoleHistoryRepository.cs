using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UserRoleHistoryRepository : IUserRoleHistoryRepository
    {
        private readonly ForeningsPortalenContext _foreningsPortalenContext;
        public UserRoleHistoryRepository(ForeningsPortalenContext foreningsPortalenContext)
        {
            _foreningsPortalenContext = foreningsPortalenContext;
        }

        void IUserRoleHistoryRepository.AddUserRoleHistory(UserRoleHistory userRoleHistory)
        {
            throw new NotImplementedException();
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
