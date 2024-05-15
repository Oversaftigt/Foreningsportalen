using _3.semesterProjekt.Application.Features.Users.Commands;
using _3.semesterProjekt.Application.Features.Users.Commands.DTOs;
using _3.semesterProjekt.Application.Features.Users.Queries;
using _3.semesterProjekt.Application.Features.Users.Queries.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;


namespace _3.semesterProjekt.Api.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserQuery _UserQuery;
        private readonly IUserCommands _UserCommands;

        public UserController(IUserQuery userQuery, IUserCommands userCommands)
        {
            _UserQuery = userQuery;
            _UserCommands = userCommands;
        }

        [HttpGet]
        public ActionResult<UserDto> GetUser(Guid userId)
        {
            var result = _UserQuery.GetUserById(userId);
            return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetAllUsers(Guid unionId)
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


        [HttpPut]
        public ActionResult Put([FromBody] UserUpdateRequestDto request)
        {

        }



    }
}
