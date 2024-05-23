using ForeningsPortalen.Website.DTOs.Member;

namespace ForeningsPortalen.WebApp.Contract
{
    public interface IMemberService
    {
            Task Create(MemberCreateRequestDto dto);
            Task Edit(MemberUpdateRequestDto memberUpdateRequest);
            Task<MemberQueryResultDto?> Get(int id, string identityName);
            //Task<IEnumerable<MemberQueryResultDto>?> GetAll(string identityName);
      
    }
}
