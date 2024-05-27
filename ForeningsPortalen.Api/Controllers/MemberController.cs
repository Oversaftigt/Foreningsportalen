﻿using ForeningsPortalen.Application.Features.Users.UnionMembers.Commands;
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
        private readonly IMemberCommands _UnionMemberCommands;
        private readonly IMemberQueries _UnionMemberQueries;

        public MemberController(IMemberCommands unionMemberCommands, IMemberQueries unionMemberQueries)
        {
            _UnionMemberCommands = unionMemberCommands;
            _UnionMemberQueries = unionMemberQueries;
        }
        // GET: api/<UnionMemberController>
        [HttpGet("{unionMemberId}")]
        public ActionResult<MemberQueryResultDto> GetMemberById(Guid unionMemberId)
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

        //[HttpGet("byEmail/{email}")]
        //public ActionResult<MemberQueryResultDto> GetMemberById(string email)
        //{
        //    try
        //    {
        //        var unionMember = _UnionMemberQueries.GetUnionMemberByUserId(unionMemberId);

        //        if (unionMember == null)
        //        {
        //            return NotFound();
        //        }
        //        return Ok(unionMember);
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }
        //}

        // GET api/<UnionMemberController>/5
        [HttpGet("AllTenants/ByUnion/{unionId}")]
        public ActionResult<IEnumerable<MemberQueryResultDto>> GetMembersByUnionId(Guid unionId)
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
        public ActionResult Post([FromBody] MemberCreateRequestDto createRequestDto)
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
        public ActionResult Put([FromBody] MemberUpdateRequestDto UpdateRequestDto)
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
        public ActionResult Delete([FromBody] SharedEntityDeleteDto deleteRequestDto)
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
