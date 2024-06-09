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
        private readonly IUserQueries _userQueries;
        private readonly IUserCommands _userCommands;

        public UserController(IUserQueries userQuery, IUserCommands userCommands)
        {
            _userQueries = userQuery;
            _userCommands = userCommands;
        }

        [HttpGet("{userId}")]
        public ActionResult<UserQueryResultDto> GetUser(Guid userId)
        {
            try
            {
                var result = _userQueries.GetUserById(userId);
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
                var result = _userQueries.GetUserByUnionId(unionId);
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
                _userCommands.CreateUser(request);
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
                _userCommands.UpdateUser(request);
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
                _userCommands.DeleteUser(deleteRequestDto);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
