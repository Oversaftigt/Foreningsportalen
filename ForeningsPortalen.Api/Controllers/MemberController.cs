using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands.DTOs;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries;
using ForeningsPortalen.Application.Features.Users.UnionMembers.Queries.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ForeningsPortalen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberCommands _unionMemberCommands;
        private readonly IMemberQueries _unionMemberQueries;

        public MemberController(IMemberCommands unionMemberCommands, IMemberQueries unionMemberQueries)
        {
            _unionMemberCommands = unionMemberCommands;
            _unionMemberQueries = unionMemberQueries;
        }
        // GET: api/<UnionMemberController>
        [HttpGet("{unionMemberId:guid}")]
        public ActionResult<MemberQueryResultDto> GetMemberById(Guid unionMemberId)
        {
            try
            {
                var unionMember = _unionMemberQueries.GetUnionMemberByUserId(unionMemberId);

                if (unionMember == null)
                {
                    return NotFound(new { message = "Member not found" });
                }
                return Ok(unionMember);
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/<UnionMemberController>
        [HttpGet("{email}")]
        public ActionResult<MemberQueryResultDto> GetMemberByEmail(string email)
        {
            try
            {
                var unionMember = _unionMemberQueries.GetUnionMemberByEmail(email);

                if (unionMember == null)
                {
                    return NotFound(new { message = "Member not found" });
                }
                return Ok(unionMember);
            }
            catch
            {
                return NotFound();
            }
        }

        // GET api/<UnionMemberController>/5
        [HttpGet("union/{unionId}/member")]
        public ActionResult<IEnumerable<MemberQueryResultDto>> GetMembersByUnionId(Guid unionId)
        {
            try
            {
                var unionMembers = _unionMemberQueries.GetUnionMembersByUnion(unionId).ToList();

                if (!unionMembers.Any())
                {
                    return NoContent();
                }
                return Ok(unionMembers.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }

        }

        // POST api/<UnionMemberController>
        [HttpPost]
        public ActionResult Post([FromBody] MemberCreateRequestDto createRequestDto)
        {
            try
            {
                _unionMemberCommands.CreateUnionMember(createRequestDto);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // PUT api/<UnionMemberController>/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] MemberUpdateRequestDto updateRequestDto)
        {
            try
            {
                _unionMemberCommands.UpdateUnionMember(updateRequestDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        // DELETE api/<UnionMemberController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] SharedEntityDeleteDto deleteRequestDto)
        {
            try
            {
                _unionMemberCommands.DeleteUnionMember(deleteRequestDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
