using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using ForeningsPortalen.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnionMemberController : ControllerBase
    {
        private readonly IUnionMemberCommands _UnionMemberCommands;
        private readonly IUnionMemberQueries _UnionMemberQueries;

        public UnionMemberController(IUnionMemberCommands unionMemberCommands, IUnionMemberQueries unionMemberQueries)
        {
            _UnionMemberCommands = unionMemberCommands;
            _UnionMemberQueries = unionMemberQueries;
        }
        // GET: api/<UnionMemberController>
        [HttpGet("{unionMemberId}")]
        public ActionResult<UnionMemberQueryResultDto> GetUNionMemberById(Guid unionMemberId)
        {
            try
            {
                var unionMember = _UnionMemberQueries.GetUnionMemberByUserId(unionMemberId);

                if (unionMember == null)
                {
                    return NotFound();
                }
                return Ok(unionMember);
            }
            catch
            {
                return NotFound();
            }
        }

        // GET api/<UnionMemberController>/5
        [HttpGet("/ByUnion/{unionId}")]
        public ActionResult<IEnumerable<UnionMemberQueryResultDto>> GetUnionMembersByUnionId(Guid unionId)
        {
            var unionMembers = _UnionMemberQueries.GetUnionMembersByUnion(unionId).ToList();

            if (!unionMembers.Any())
            {
                return BadRequest();
            }
            return Ok(unionMembers.ToList());
        }

        // POST api/<UnionMemberController>
        [HttpPost]
        public ActionResult Post([FromBody] UnionMemberCreateRequestDto createRequestDto)
        {
            try
            {
                _UnionMemberCommands.CreateUnionMember(createRequestDto);
                return Created();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<UnionMemberController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] UnionMemberUpdateRequestDto UpdateRequestDto)
        {
            try
            {
                _UnionMemberCommands.UpdateUnionMember(UpdateRequestDto);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE api/<UnionMemberController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] UnionMemberDeleteRequestDto deleteRequestDto)
        {
            try
            {
                _UnionMemberCommands.DeleteUnionMember(deleteRequestDto);
                return NoContent();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
