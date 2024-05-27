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
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace ForeningsPortalen.Website.Pages.Admin.Members
{
    [Authorize(Policy = "AdministratorAccess")]
    public class RegisterMemberModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserStore<IdentityUser> _userStore;
        private readonly ILogger<RegisterMemberModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly IAddressService _addressService;
        private readonly IMemberService _memberService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRoleService _roleService;


        public RegisterMemberModel(UserManager<IdentityUser> userManager,
                                   IUserStore<IdentityUser> userStore,
                                   SignInManager<IdentityUser> signInManager,
                                   IUserEmailStore<IdentityUser> emailStore,
                                   ILogger<RegisterMemberModel> logger,
                                   IEmailSender emailSender,
                                   IAddressService addressService,
                                   IMemberService memberService,
                                   IUnitOfWork unitOfWork,
                                   IRoleService roleService)
        {
            _userManager = userManager;
            _userStore = userStore;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _addressService = addressService;
            _memberService = memberService;
            _unitOfWork = unitOfWork;
            _roleService = roleService;

        }

        [BindProperty]
        public CreateMemberModel CreateMember { get; set; } = new();
        public List<AddressIndexModel> UnionAddresses { get; set; } = new List<AddressIndexModel>();
        public List<Dictionary<Guid, string>> Roles { get; set; } = new();

        [BindProperty]
        public Guid UnionId { get; set; }

        //public string ReturnUrl { get; set; }

        public async Task OnGetAsync(/*string returnUrl = null*/)
        {
            var activeUnionId = User.Claims.FirstOrDefault(x => x.Type == "UnionId").Value;
            if (activeUnionId != null)
            {

                UnionId = Guid.Parse(activeUnionId);

                var allAddresses = await _addressService.GetAllAddressesAsync(UnionId);

                if (allAddresses != null)
                {
                    //Address = new List<AddressIndexModel>();
                    allAddresses?.ToList().ForEach(dto => UnionAddresses.Add(new AddressIndexModel
                    { Street = dto.Street, StreetNumber = dto.Number, ZipCode = dto.PostalCode, City = dto.CityName, Id = dto.Id }));
                }

                var allRoles = await _roleService.GetAllRolesAsync();
                if (allRoles != null)
                {
                    Roles.AddRange(allRoles.Select(dto => new Dictionary<Guid, string>
    {
        { dto.Id, dto.RoleName }
    }));
                }
            var password = CreateInitialPassword();
            CreateMember.Password = password;
            CreateMember.ConfirmPassword = CreateMember.Password;
            }

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            //returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                _unitOfWork.BeginTransaction();


                await CreateDetailedUnionMember();
                var user = await CreateIdentityUser();

                if (_userStore == null)
                {
                    throw new InvalidOperationException("User store is not initialized.");
                }

                if (CreateMember == null)
                {
                    throw new InvalidOperationException("CreateMember is not initialized.");
                }

                if (string.IsNullOrEmpty(CreateMember.Email))
                {
                    throw new InvalidOperationException("CreateMember.Email is not initialized or empty.");
                }


                await _userStore.SetUserNameAsync(user, CreateMember.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, CreateMember.Password);

                if (result.Succeeded)
                {
                    //_logger.LogInformation($"User created a new account with generated {CreateMember.Password}.");

                    //var userId = await _userManager.GetUserIdAsync(user);
                    //var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    //code = WebEncoders.Base64UrlEncode(System.Text.Encoding.UTF8.GetBytes(code));
                    //var callbackUrl = Url.Page(
                    //    "/Account/ResetPassword",
                    //    pageHandler: null,
                    //    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    //    protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(CreateMember.Email, "Skift din kode, før du kan tilgå din Boligportal",
                    //   $"Brug dette link til at tilgå siden, hvor du kan skifte din kode " +
                    //   $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    _unitOfWork.Commit();
                }
                else
                {
                    _unitOfWork.Rollback();
                    foreach (var error in result.Errors)
                    {

                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }

            }
            return Page();
        }

        private async Task CreateDetailedUnionMember()
        {
            try
            {

                var dto = new MemberCreateRequestDto
                {
                    FirstName = CreateMember.FirstName,
                    LastName = CreateMember.LastName,
                    Email = CreateMember.Email,
                    PhoneNumber = CreateMember.Phone ?? "",
                    RoleId = CreateMember.RoleId,
                    MoveInDate = CreateMember.MoveInDate,
                    UnionId = UnionId,
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

        private string CreateInitialPassword()
        {
            try
            {
                Random _random = new Random();

                string[] Words = new[]
               {
                     "alpha", "bravo", "charlie", "delta", "echo", "foxtrot", "golf", "hotel", "india",
                     "juliet", "kilo", "lima", "mike", "november", "oscar", "papa", "quebec", "romeo",
                     "sierra", "tango", "uniform", "victor", "whiskey", "xray", "yankee", "zulu"
        };

                string SpecialChars = "!@#$%^&*?";
                string upperCaseLetters = "ROGJSCNJRHLDVJGHECWÅS";

                int wordCount = 3;

                var password = new StringBuilder();
                for (int i = 0; i < wordCount; i++)
                {
                    var randomWord = Words[_random.Next(Words.Length)];
                    password.Append(randomWord);
                }

                var randomNumber = _random.Next(100, 1000);
                password.Append(randomNumber);

                var randomSpecialChar = SpecialChars[_random.Next(SpecialChars.Length)];
                password.Append(randomSpecialChar);

                var randomUpperCase = upperCaseLetters[_random.Next(upperCaseLetters.Length)];
                password.Append(randomUpperCase);

                return new string(password.ToString().OrderBy(c => _random.Next()).ToArray());

            }
            catch
            {
                throw new InvalidOperationException($"Password failed to be created");
            }
        }
    }
}
