using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Pages.Admin.Unions;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ForeningsPortalen.Website.HelperServices
{
    public class UserClaimsService : IUserClaimsService
    {
        private readonly IUnionService _unionService;
        private readonly ILogger<ChooseUnionModel> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;


        public UserClaimsService(ILogger<ChooseUnionModel> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IUnionService unionService)
        {
            _unionService = unionService;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }
       
        public async Task<bool> ReplaceClaimOnUserByEmail(string userEmail, string claimType, string claimValue)
        {
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user is null)
            {
                _logger.LogError($"Unable to find a user with email: '{userEmail}'.");
                return false;
            }
            
            var userClaims = await _userManager.GetClaimsAsync(user);
            if (userClaims is null)
            {
                _logger.LogError($"Unable to get claims on user with ID: '{user.Id}'.");
                return false;
            }

            var oldClaim = (await _userManager.GetClaimsAsync(user)).FirstOrDefault(x => x.ValueType == claimType);
            if (oldClaim != null)
            {
                var removeClaimResult = await _userManager.RemoveClaimAsync(user, oldClaim);
                if (!removeClaimResult.Succeeded)
                {
                    _logger.LogError($"Unable to remove claim '{oldClaim.ToString}'.");
                    return false;
                }   
            }

            var newClaim = new Claim(claimType, claimValue);
            var addClaimResult = await _userManager.AddClaimAsync(user, newClaim);
            if (!addClaimResult.Succeeded)
            {
                _logger.LogError($"Unable to add claim: '{newClaim.ToString}' to user with ID: '{user.Id}'.");
                return false;
            }

            await _signInManager.RefreshSignInAsync(user);
            return true;
        }
    }
}
