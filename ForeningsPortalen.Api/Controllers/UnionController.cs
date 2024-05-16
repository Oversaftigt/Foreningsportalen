using ForeningsPortalen.Application.Features.Unions.Commands;
using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Features.Unions.Queries;
using ForeningsPortalen.Domain.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ForeningsPortalen.Api.Controllers
{
    public class UnionController : ControllerBase
    {
        private readonly IUnionQuery _Query;
        private readonly IUnionCommands _Commands;
        public UnionController(IUnionQuery query, IUnionCommands commands)
        {
            _Query = query;
            _Commands = commands;
        }
        [HttpGet]
        public ActionResult<Union> GetUnion(Guid id)
        {
            var result = _Query.GetUnionWithId(id);
            if(result == null)
                return NotFound(result);
           
            else return Ok(result);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Union>> GetAllUnions()
        {
            var result = _Query.GetAllUnions().ToList();
            if(!result.Any())
                return NotFound(result);

           else return Ok(result);
        }

        [HttpPut]
        public ActionResult UpdateUnion(UnionCommandUpdateDto unionCommandUpdateDto)
        {
            try
            {
                _Commands.UpdateUnion(unionCommandUpdateDto);
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
                _Commands.CreateUnion(unionCommandCreateDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpDelete]
        public ActionResult DeleteUnion(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}

