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
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ForeningsPortalenContext _dbCopntext;
        public UserRoleRepository(ForeningsPortalenContext dbContext)
        {
            _dbCopntext = dbContext;
        }

        void IUserRoleRepository.AddUserRole(UserRoleHistory userRole)
        {
            throw new NotImplementedException();
        }

        void IUserRoleRepository.DeleteUserRole(UserRoleHistory userRole, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        UserRoleHistory IUserRoleRepository.GetUserRole(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUserRoleRepository.UpdateUserRole(UserRoleHistory userRole, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
