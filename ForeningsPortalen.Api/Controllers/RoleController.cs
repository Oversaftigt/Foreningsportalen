using ForeningsPortalen.Application.Features.Roles.Commands;
using ForeningsPortalen.Application.Features.Roles.Queries;
using ForeningsPortalen.Application.Features.Roles.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleQueries _roleQueries;
        private readonly IRoleCommands _roleCommands;

        public RoleController(IRoleQueries roleQueries, IRoleCommands roleCommands)
        {
            _roleQueries = roleQueries;
            _roleCommands = roleCommands;
        }


        [HttpGet]
        public ActionResult<IEnumerable<RoleQueryResultDto>> GetAllRoles()
        {
            var result = _roleQueries.GetAllRoles();
            if (!result.Any())
                return NotFound(result);

            else return Ok(result);
        }
    }
}
