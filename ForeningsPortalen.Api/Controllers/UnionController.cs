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
        public UnionController(IUnionQuery query, IUnionCommands commands)
        {
            _Query = query;
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
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult CreateUnion(UnionCommandCreateDto unionCommandCreateDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult DeleteUnion(Guid id)
        {
            throw new NotImplementedException();
        }

    }
}

