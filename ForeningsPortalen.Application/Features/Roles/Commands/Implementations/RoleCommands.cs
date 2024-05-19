using ForeningsPortalen.Application.Features.Roles.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Commands.Implementations
{
    public class RoleCommands : IRoleCommands
    {
        private readonly IRoleRepository _roleRepository;
        public RoleCommands(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
    }
}
