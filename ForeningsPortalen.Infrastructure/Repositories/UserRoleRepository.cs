using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Domain.Entities;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public UserRoleRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IUserRoleRepository.AddUserRole(UserRoleHistory userRole)
        {
            _dbContext.Add(userRole);
            _dbContext.SaveChanges();
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
