using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IMemberRepository
    {
        /// <summary>
        /// Add a new union member to the database
        /// </summary>
        /// <param name="unionMember"></param>
        void CreateUnionMember(Member unionMember);

        /// <summary>
        /// Update an existing member
        /// </summary>
        /// <param name="unionMember"></param>
        /// <param name="rowVersion"></param>
        void UpdateUnionMember(Member unionMember, byte[] rowVersion);

        /// <summary>
        /// Delete a member
        /// </summary>
        /// <param name="unionMember"></param>
        /// <param name="rowVersion"></param>
        void DeleteUnionMember(Member unionMember, byte[] rowVersion);

        /// <summary>
        /// Get a specific member by its Id
        /// </summary>
        /// <param name="unionMemberId"></param>
        /// <returns></returns>
        Member GetUnionMember(Guid unionMemberId);
    }
}
