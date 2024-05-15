using _3.semesterProjekt.Application.Features.Users.Commands.DTOs;
using _3.semesterProjekt.Application.Features.Users.Commands;
using _3.semesterProjekt.Application.Features.Users.Queries.DTOs;
using _3.semesterProjekt.Application.Features.Users.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _3.semesterProjekt.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTestController : ControllerBase
    {
        private readonly IUserQuery _UserQuery;
        private readonly IUserCommands _UserCommands;

        public UserTestController(IUserQuery userQuery, IUserCommands userCommands)
        {
            _UserQuery = userQuery;
            _UserCommands = userCommands;
        }

        //[HttpGet]

        //public ActionResult<UserQueryResultDto> GetUser(Guid userId)
        //{
        //    var result = _UserQuery.GetUserById(userId);
        //    return Ok(result);
        //}

        //[HttpGet]
        //public ActionResult<IEnumerable<UserQueryResultDto>> GetAllUsers(Guid unionId)
        //{
        //    var result = _UserQuery.GetUsersByUnionId(unionId);
        //    return Ok(result);
        //}

        //[HttpPost]
        //public ActionResult Post([FromBody] UserCreateRequestDto request)
        //{
        //    try
        //    {
        //        _UserCommands.CreateUser(request);
        //        return Created();
        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }
        //}


        //[HttpPut]
        //public ActionResult Put([FromBody] UserUpdateRequestDto request)
        //{
        //    try
        //    {
        //        _UserCommands.UpdateUser(request);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
