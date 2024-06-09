using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ForeningsPortalen.Website.Models.Address;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using ForeningsPortalen.Website.HelperServices;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using ForeningsPortalen.Website.Models.Union;


namespace ForeningsPortalen.Website.Pages.Admin.Unions
{
    [Authorize(Policy = "AdministratorAccess")]
    public class ChooseUnionModel : PageModel
    {
        private readonly IUnionService _unionService;
        private readonly IUserClaimsService _userClaimsService;
        private readonly ILogger<ChooseUnionModel> _logger;


        public ChooseUnionModel(ILogger<ChooseUnionModel> logger, IUnionService unionService, IUserClaimsService userClaimsService)
        {
            _unionService = unionService;
            _userClaimsService = userClaimsService;
            _logger = logger;
        }

        [BindProperty]
        public List<IndexUnion>? Unions { get; set; } = new List<IndexUnion>();

        [BindProperty]
        public IndexUnion SelectedUnion { get; set; }


        public async Task<IActionResult> OnGet()
        {
            var allUnions = await _unionService.GetAllUnionsAsync();
            //if (!allUnions.Any())
            //{
            //    return RedirectToPage("./Create");
            //} //todo check dette virker

            allUnions?.ToList().ForEach(dto => Unions.Add(new IndexUnion
            { Name = dto.Name, Id = dto.Id }));

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (SelectedUnion != null)
            {
                if (!User.Identity.IsAuthenticated)
                {
                    return Unauthorized();
                }

                // Get the current administrator's email
                var adminEmail = User.Identity.Name;
                if (string.IsNullOrEmpty(adminEmail))
                {
                    return Unauthorized();
                }

                var result = await _userClaimsService.ReplaceClaimOnUserByEmail(adminEmail, "UnionId", SelectedUnion.Id.ToString());
                if (result)
                {
                    return RedirectToPage("/Index", new { UnionPortal = SelectedUnion.Name });
                }

            }

            ModelState.AddModelError(string.Empty, "Vælg en Union");
            return Page();
        }
    }
}
