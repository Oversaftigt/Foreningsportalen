using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace _3.semesterProjekt.Api.Controllers
{
    public class UserController
    {
        [HttpGet]
        public async Task<UserDto> Get()
        {

        }

        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get(int unionId)
        {
            var result = IUserQuery.GetUsersByUnion(unionId);
            return result;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEditRequestDto request)
        {

        }


        [HttpPut]

    }
}
