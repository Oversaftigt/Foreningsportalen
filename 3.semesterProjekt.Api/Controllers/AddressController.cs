using _3.semesterProjekt.Application.Features.Addresses.Commands.DTOs;
using _3.semesterProjekt.Application.Features.Addresses.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace _3.semesterProjekt.Api.Controllers
{
    public class AddressController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<AddressQueryDto>> GetAddressesByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<AddressQueryDto> GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task PostAddress(AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task UpdateAddress(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
