using ForeningsPortalen.Application.Features.Users.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ForeningsPortalen.Api.Controllers
{
    public class UserController
    {
        [HttpGet]
        public async Task<UserDto> Get()
        {
            var user = new UserDto();
            return user;
        }

        [HttpPost]
        public void Post([FromBody] Application.Features.Users.Commands.UserEditRequestDto request)
        {
           
        }


 
    }
}
