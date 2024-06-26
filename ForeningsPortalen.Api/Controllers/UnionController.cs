﻿using ForeningsPortalen.Application.Features.Unions.Commands;
using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Application.Features.Unions.Queries.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnionController : ControllerBase
    {
        private readonly IUnionQueries _unionQueries;
        private readonly IUnionCommands _unionCommands;
        public UnionController(IUnionQueries query, IUnionCommands commands)
        {
            _unionQueries = query;
            _unionCommands = commands;
        }
        [HttpGet("{id}")]
        public ActionResult<UnionQueryResultDto> GetUnion(Guid id)
        {
            var result = _unionQueries.GetUnionById(id);
            if (result == null)
                return NotFound(result);

            else return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<UnionQueryResultDto>> GetAllUnions()
        {
            var result = _unionQueries.GetAllUnions().ToList();
            if (!result.Any())
                return NoContent();

            return Ok(result);
        }

        [HttpPut("{unionCommandUpdateDto.Id}")]
        public ActionResult UpdateUnion([FromBody] UnionCommandUpdateDto unionCommandUpdateDto)
        {
            try
            {
                _unionCommands.UpdateUnion(unionCommandUpdateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult CreateUnion(UnionCommandCreateDto unionCommandCreateDto)
        {
            try
            {
                _unionCommands.CreateUnion(unionCommandCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUnion([FromBody]SharedEntityDeleteDto deleteDto)
        {
            try
            {
                _unionCommands.DeleteUnion(deleteDto);
                return Ok();

            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

