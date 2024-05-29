using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Commands.DTOs;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries;
using ForeningsPortalen.Application.Features.Users.BaseUsers.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserQueries _UserQueries;
        private readonly IUserCommands _UserCommands;

        private List<UserQueryResultDto> _QueryResult = new List<UserQueryResultDto>();

        public UserController(IUserQueries userQuery, IUserCommands userCommands)
        {
            _UserQueries = userQuery;
            _UserCommands = userCommands;
        }

        [HttpGet("{userId}")]
        public ActionResult<UserQueryResultDto> GetUser(Guid userId)
        {
            try
            {
                var result = _UserQueries.GetUserById(userId);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet("union/{unionId}/user")]
        public ActionResult<IEnumerable<UserQueryResultDto>> GetAllUsers(Guid unionId)
        {
            try
            {
                var result = _UserQueries.GetUserByUnionId(unionId);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }

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

        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] UserDeleteRequestDto deleteRequestDto)
        {
            try
            {
                _UserCommands.DeleteUser(deleteRequestDto);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
