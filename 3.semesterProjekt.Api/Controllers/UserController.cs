using _3.semesterProjekt.Application.Features.Users.Commands;
using _3.semesterProjekt.Application.Features.Users.Queries;
using _3.semesterProjekt.Application.Features.Users.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace _3.semesterProjekt.Api.Controllers
{
    public class UserController
    {
        private readonly IUserQuery _UserQuery;
        private readonly IUserCommands _UserCommands;

        public UserController(IUserQuery userQuery, IUserCommands userCommands)
        {
            _UserQuery = userQuery;
            _UserCommands = userCommands;
        }

        [HttpGet]
        public async Task<UserDto> Get(Guid userId)
        {
            var result = _UserQuery.GetUserById(userId);
            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get(int unionId)
        {
            var result = _UserQuery.GetUsersByUnionId(unionId);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEditRequestDto request)
        {

        }


        [HttpPut]

    }
}
