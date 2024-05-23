using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;
using ForeningsPortalen.Application.Features.UserRoles.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Roles.Queries
{
    public interface IRoleQueries
    {
        List<RoleQueryResultDto> GetAllRoles();
        RoleQueryResultDto GetRole(Guid id);
    }
}
