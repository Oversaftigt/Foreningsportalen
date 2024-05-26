using ForeningsPortalen.Website.HelperServices;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Address;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Address;
using ForeningsPortalen.Website.Models.Member;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Website.Pages.Admin.Members
{
    [Authorize(Policy = "AdministratorAccess")]
    public class RegisterMemberModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly IUserEmailStore<IdentityUser> _emailStore;
        private readonly ILogger<RegisterMemberModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IAddressService _addressService;
        private readonly IMemberService _memberService;
        private readonly IUnitOfWork _unitOfWork;


        public RegisterMemberModel(UserManager<IdentityUser> userManager,
                                   IUserStore<IdentityUser> userStore,
                                   SignInManager<IdentityUser> signInManager,
                                   IUserEmailStore<IdentityUser> emailStore,
                                   ILogger<RegisterMemberModel> logger,
                                   IEmailSender emailSender,
                                   IAddressService addressService,
                                   IMemberService memberService,
                                   IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _addressService = addressService;
            _memberService = memberService;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public CreateMemberModel CreateMember { get; set; }
        public List<AddressIndexModel> UnionAddresses { get; set; } = new List<AddressIndexModel>();
        public Guid UnionId { get; set; }

        public IUserEmailStore<IdentityUser> EmailStore => _emailStore;

        //public string ReturnUrl { get; set; }

        public async Task OnGetAsync(/*string returnUrl = null*/)
        {
            var activeUnionId = User.Claims.FirstOrDefault(x => x.Type == "UnionPortal");
            if (activeUnionId != null)
            {
                var allAddresses = await _addressService.GetAllAddressesAsync(Guid.Parse(activeUnionId.Value));

                if (allAddresses != null)
                {
                    //Address = new List<AddressIndexModel>();
                    allAddresses?.ToList().ForEach(dto => UnionAddresses.Add(new AddressIndexModel
                    { Street = dto.Street, StreetNumber = dto.Number, ZipCode = dto.PostalCode, City = dto.CityName, Id = dto.Id }));
                }
            }

        }


        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                _unitOfWork.BeginTransaction();

                await PostUnionMember();
                var user = await CreateIdentityUser();

                await _userStore.SetUserNameAsync(user, CreateMember.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, CreateMember.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, CreateMember.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    //var userId = await _userManager.GetUserIdAsync(user);
                    //var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ConfirmEmail",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    //{
                    //    return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    //}
                    //else
                    //{
                    //    await _signInManager.SignInAsync(user, isPersistent: false);
                    //    return LocalRedirect(returnUrl);
                    //}

                    _unitOfWork.Commit();
                }
                
                _unitOfWork.Rollback();
                foreach (var error in result.Errors)
                {
                    
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            // If we got this far, something failed, redisplay form
            return Page();
        }

        private async Task PostUnionMember()
        {
            try
            {
                var dto = new MemberCreateRequestDto
                {
                    FirstName = CreateMember.FirstName,
                    LastName = CreateMember.LastName,
                    Email = CreateMember.Email,
                    PhoneNumber = CreateMember.Phone ?? "",
                    RoleId = CreateMember.Role,
                    MoveInDate = CreateMember.MoveInDate,
                    UnionId = CreateMember.UnionId,
                    AddressId = CreateMember.AddressId
                };
                await _memberService.PostMemberAsync(dto);
            }
            catch 
            {
                throw new InvalidOperationException($"Something went wrong and the Request " +
                    $"                              to Post an instance of a member " +
                    $"                              on ForeningsPortalen api failed.");
            }
        }


        private async Task<IdentityUser> CreateIdentityUser()
        {
            try
            {

                return Activator.CreateInstance<IdentityUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityUser)}'. " +
                    $"Ensure that '{nameof(IdentityUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        //private async Task<ActionResult> RegisterUser()
        //{

        //}
        //private async Task<string> CreateInitialPassword()
        //{

        //}

    }
}
