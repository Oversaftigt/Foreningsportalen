
using Microsoft.AspNetCore.Identity;

namespace ForeningsPortalen.Website.HelperServices
{
    public interface IUserClaimsService
    {
        /// <summary>
        /// returns a true or false statement to se of a claim should be replaced. using userEmail
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="claimType"></param>
        /// <param name="claimValue"></param>
        /// <returns></returns>
        Task<bool> ReplaceClaimOnUserByEmail(string userEmail, string claimType, string claimValue);
    }
}