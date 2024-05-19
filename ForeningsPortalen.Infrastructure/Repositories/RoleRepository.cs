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
    public class RoleRepository : IRoleRepository
    {
        private readonly ForeningsPortalenContext _dbContext;
        public RoleRepository(ForeningsPortalenContext dbContext)
        {
            _dbContext = dbContext;
        }

        void IRoleRepository.AddRole(Role role)
        {
            throw new NotImplementedException();
        }

        void IRoleRepository.DeleteRole(Role role, byte[] rowversion)
        {
            throw new NotImplementedException();
        }

        Role IRoleRepository.GetRole(Guid id)
        {
            throw new NotImplementedException();
        }

        void IRoleRepository.UpdateRole(Role role, byte[] rowversion)
        {
            throw new NotImplementedException();
        }
    }
}
