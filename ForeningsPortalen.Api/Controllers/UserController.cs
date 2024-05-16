using ForeningsPortalen.Application.Features.Users.Commands;
using ForeningsPortalen.Application.Features.Users.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ForeningsPortalen.Api.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private readonly IUserQuery _UserQuery;
            private readonly IUserCommands _UserCommands;

            public UserController(IUserQuery userQuery, IUserCommands userCommands)
            {
                _UserQuery = userQuery;
                _UserCommands = userCommands;
            }

            [HttpGet("{userId}")]
            public ActionResult<UserQueryResultDto> GetUser(Guid userId)
            {
                var result = _UserQuery.GetUserById(userId);
                return Ok(result);
            }

            [HttpGet("ByUnion/{unionId}")]
            public ActionResult<IEnumerable<UserQueryResultDto>> GetAllUsers(Guid unionId)
            {
                var result = _UserQuery.GetUsersByUnionId(unionId);
                return Ok(result);
            }

            [HttpPost]
            public ActionResult Post([FromBody] UserCreateRequestDto request)
            {
                try
                {
                    _UserCommands.CreateUser(request);
                    return Created();
                }
                catch
                {
                    return BadRequest();
                }
            }

            [HttpPut("{id}")]
            public ActionResult Put([FromBody] UserUpdateRequestDto request)
            {
                try
                {
                    _UserCommands.UpdateUser(request);
                    return NoContent();
                }
                catch
                {
                    return BadRequest();
                }
            }

        }
}
