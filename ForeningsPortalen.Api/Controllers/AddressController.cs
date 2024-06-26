﻿using ForeningsPortalen.Application.Features.Addresses.Commands;
using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Addresses.Queries;
using ForeningsPortalen.Application.Features.Addresses.Queries.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressQueries _addressQueries;
        private readonly IAddressCommands _addressCommand;
        private readonly ILogger<AddressController> _logger;

        public AddressController(IAddressQueries addressQueries, IAddressCommands addressCommand, ILogger<AddressController> logger)
        {
            _addressQueries = addressQueries;
            _addressCommand = addressCommand;
            _logger = logger;
        }

        [HttpGet("union/{unionId}/address")]
        public ActionResult<IEnumerable<AddressQueryResultDto>> GetAddressesByUnionId(Guid unionId)
        {
            try
            {
                var addressesInUnion = _addressQueries.GetAddressesByUnion(unionId);
                if (addressesInUnion.Any() is false)
                {
                    return NoContent();
                }
                return Ok(addressesInUnion);

            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occured while getting addresses by union id: {unionId}", ex);
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{addressId}")]
        public ActionResult<AddressQueryResultDto> GetByAddress(Guid addressId)
        {
            try
            {
                var addressesInUnion = _addressQueries.GetAddressById(addressId);
                return Ok(addressesInUnion);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult PostAddress([FromBody] AddressCreateRequestDto addressCreateRequestDto)
        {
            try
            {
                _addressCommand.CreateAddress(addressCreateRequestDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
