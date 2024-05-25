using ForeningsPortalen.Website.DTOs.Member;

namespace ForeningsPortalen.Website.Contract
{
    public interface IMemberService
    {
        Task Create(MemberCreateRequestDto memberCreateRequest);
        Task Edit(MemberUpdateRequestDto memberUpdateRequest);
        Task<MemberQueryResultDto?> Get(int id, string identityName);
        //Task<IEnumerable<MemberQueryResultDto>?> GetAll(string identityName);

    }
}
