﻿using ForeningsPortalen.Application.Features.Addresses.Commands;
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
        private readonly IAddressQueries _addressQueries;
        private readonly IAddressCommands _addressCommand;

        public AddressController(IAddressQueries addressQueries, IAddressCommands addressCommand)
        {
            _addressQueries = addressQueries;
            _addressCommand = addressCommand;
        }

        [HttpGet("{unionId}")]
        public ActionResult<IEnumerable<AddressQueryResultDto>> GetAddressesByUnionId(Guid unionId)
        {
            var addressesInUnion = _addressQueries.GetAddressesByUnion(unionId);
            return Ok(addressesInUnion);
        }

        [HttpGet]
        public AddressQueryResultDto GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult PostAddress([FromBody] AddressCreateRequestDto addressCreateRequestDto)
        {
            try
            {
                _addressCommand.CreateAddress(addressCreateRequestDto);
                return Created();

            }
            catch
            {
                return BadRequest();
            }
            
        }

        [HttpPut]
        void UpdateAddress([FromBody] AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        void DeleteAddress(Guid addressId)
        {
            throw new NotImplementedException();
        }
    }
}
