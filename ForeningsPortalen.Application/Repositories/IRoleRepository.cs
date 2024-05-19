using ForeningsPortalen.Domain.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IRoleRepository
    {
        void AddRole(Role role);
        void UpdateRole(Role role, byte[] rowversion);
        void DeleteRole(Role role, byte[] rowversion);
        Role GetRole(Guid id);
    }
}
