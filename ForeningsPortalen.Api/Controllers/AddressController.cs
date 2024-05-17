using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Commands.Interfaces;
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
        private readonly IAddressCommand addressCommand;

        public AddressController(IAddressQuery addressQuery, IAddressCommand addressCommand)
        {
            _addressQuery = addressQuery;
            this.addressCommand = addressCommand;
        }

        [HttpGet("{unionId}")]
        public ActionResult<IEnumerable<AddressQueryResultDto>> GetAddressesByUnionId(Guid unionId)
        {
            AddressQueryResultDto h = new();
            h.City = "vejle";
            List<AddressQueryResultDto> de = new();
            de.Add(h);
            return Ok(de);
        }

        [HttpGet]
        public AddressQueryResultDto GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void PostAddress([FromBody] AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void UpdateAddress([FromBody] AddressUpdateRequestDto addressUpdateRequestDto)
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
