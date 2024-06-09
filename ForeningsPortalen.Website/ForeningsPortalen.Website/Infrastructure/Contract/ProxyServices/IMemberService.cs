﻿using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IMemberService
    {
        Task PostMemberAsync(MemberCreateRequestDto memberCreateRequest);
        Task PutMemberAsync(MemberUpdateRequestDto memberUpdateRequest);
        Task<MemberQueryResultDto> GetMemberByIdAsync(Guid memberId);
        Task<MemberQueryResultDto> GetMemberByEmailAsync(string memberEmail);
        Task<IEnumerable<MemberQueryResultDto>?> GetAllMembersAsync(Guid unionId);
    }
}
