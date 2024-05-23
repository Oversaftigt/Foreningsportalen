using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Repositories;

namespace ForeningsPortalen.Application.Features.UserRoles.Commands.Implementations
{
    public class UserRoleCommands : IUserRoleCommands
    {
        private readonly IUserRoleRepository _userRoleRepository;
        public UserRoleCommands(IUserRoleRepository userRoleRepository)
        {

            _userRoleRepository = userRoleRepository;

        }
    }
}
