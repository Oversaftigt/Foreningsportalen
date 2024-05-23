using ForeningsPortalen.Application.Features.Roles.Commands;
using ForeningsPortalen.Application.Features.Roles.Queries;
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
            _roleCommands = roleCommands;
            _roleQueries = roleQueries;
        }

        [HttpGet]
        public IActionResult GetAllRoles() 
        { 
            var result = _roleQueries.GetAllRoles();
            if (result == null)
            {
                return BadRequest("Roles not found");
            }
            return Ok(result);
        }
    }
}
