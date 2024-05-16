using ForeningsPortalen.Application.Features.Users.Commands;
using ForeningsPortalen.Application.Features.Users.Commands.DTOs;
using ForeningsPortalen.Application.Features.Users.Queries;
using ForeningsPortalen.Application.Features.Users.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserQuery _UserQuery;
        private readonly IUserCommands _UserCommands;

        private List<UserQueryResultDto> _QueryResult = new List<UserQueryResultDto>();

        public UserController( IUserQuery userQuery,IUserCommands userCommands)
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
            var userQuery = new UserQueryResultDto();
            userQuery.PhoneNumber = "23232323";

            _QueryResult.Add(userQuery);
            var userList = _QueryResult.ToList();

            //var result = _UserQuery.GetUsersByUnionId(unionId);
            return Ok(userList);
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
