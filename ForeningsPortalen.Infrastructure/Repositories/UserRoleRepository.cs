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

        void IUserRoleRepository.AddUserRole(UserRole userRole)
        {
            throw new NotImplementedException();
        }

        void IUserRoleRepository.DeleteUserRole(UserRole userRole, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }

        UserRole IUserRoleRepository.GetUserRole(Guid id)
        {
            throw new NotImplementedException();
        }

        void IUserRoleRepository.UpdateUserRole(UserRole userRole, byte[] rowVersion)
        {
            throw new NotImplementedException();
        }
    }
}
