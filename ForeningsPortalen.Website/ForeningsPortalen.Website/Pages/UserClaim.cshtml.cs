using ForeningsPortalen.Website.DTOs.Member;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages
{
    public class UserClaimModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        public UserClaimModel(UserManager<IdentityUser> userManager, IUserStore<IdentityUser> userStore)
        {
            _userManager = userManager;
            _userStore = userStore;
        }

        [BindProperty]
        public MemberQueryResultDto Member { get; set; }
        public IEnumerable<string> AllRoles { get; set; }
        public string SelectedRole { get; set; }
        public Guid UserId { get; set; }

        public void OnGet()
        {
            //_API get roles
            //Roles equals a claim
        }

        public async void OnPost() 
        {
            //var user = await _userManager.FindByEmailAsync(Member.Email);
            //if (user is null)
            //{

            //}
            //var claims = await _userManager.GetClaimsAsync(user);
            //if (claims.Any())
            //{
            //    await _userManager.RemoveClaimsAsync(user, claims);
            //    await _userManager.AddClaimAsync(user, SelectedRole)
            //    }
            //if (SelectedRole == "Administrator")
            //{
            //    _userManager.AddClaimAsync(user, SelectedRole)
            //}
            if (SelectedRole == "Bestyrelses Formand")
            {

            }
            if (SelectedRole == "Kassere")
            {

            }
            if (SelectedRole == "Bestyrelsesmedlem")
            {

            }
            if (SelectedRole == "Menig medlem")
            {


            }

        }
    }
}
