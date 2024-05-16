using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressQuery _addressQuery;

        public AddressController(IAddressQuery addressQuery)
        {
            _addressQuery = addressQuery;
        }

        [HttpGet("{unionId}")]
        public IEnumerable<AddressQueryDto> GetAddressesByUnionId(Guid unionId)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public AddressQueryDto GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void PostAddress([FromBody] AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void UpdateAddress([FromBody]AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
