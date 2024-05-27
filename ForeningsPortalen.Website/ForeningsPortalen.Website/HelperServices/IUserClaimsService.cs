
namespace ForeningsPortalen.Website.HelperServices
{
    public interface IUserClaimsService
    {
        Task<bool> ReplaceClaimOnUserByEmail(string userEmail, string claimType, string claimValue);
    }
}