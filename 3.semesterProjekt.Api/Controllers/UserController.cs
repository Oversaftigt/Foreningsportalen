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

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEditRequestDto request)
        {

        }


        [HttpPut]

    }
}
