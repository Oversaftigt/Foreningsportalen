using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface IMemberService
    {
        /// <summary>
        /// Create a new member
        /// </summary>
        /// <param name="memberCreateRequest"></param>
        /// <returns></returns>
        Task PostMemberAsync(MemberCreateRequestDto memberCreateRequest);

        /// <summary>
        /// Update an existing member
        /// </summary>
        /// <param name="memberUpdateRequest"></param>
        /// <returns></returns>
        Task PutMemberAsync(MemberUpdateRequestDto memberUpdateRequest);

        /// <summary>
        /// Get a specific member using its id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="identityName"></param>
        /// <returns></returns>
        Task<MemberQueryResultDto?> GetMemberAsync(int id, string identityName);

        /// <summary>
        /// Get a list of all members in a union, using union Id
        /// </summary>
        /// <param name="unionId"></param>
        /// <returns></returns>
        Task<IEnumerable<MemberQueryResultDto>?> GetAllMembersAsync(Guid unionId);

    }
}
