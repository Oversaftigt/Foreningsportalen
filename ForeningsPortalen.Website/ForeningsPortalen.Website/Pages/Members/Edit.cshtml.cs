using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Member;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Address;
using ForeningsPortalen.Website.Models.Member;
using Microsoft.AspNetCore.Authorization;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.CodeAnalysis.CSharp;
using NuGet.Packaging;

namespace ForeningsPortalen.Website.Pages.Members
{
    [Authorize(Policy = "AdministratorAccess")]

    public class EditModel : PageModel
    {
        private readonly ILogger _logger;
        private readonly IMemberService _memberService;
        private readonly IRoleService _roleService;

        public EditModel(ILogger logger, IMemberService memberService, IRoleService roleService)
        {
            _logger = logger;
            _memberService = memberService;
            _roleService = roleService;
        }

        [BindProperty]
        public UpdateMemberModel Member { get; set; } = default!;
        public List<Dictionary<Guid, string>> Roles { get; set; } = new();
        [BindProperty]
        public Dictionary<Guid, string> CurrentRole { get; set; } = new();

        public async Task OnGetAsync(Guid id)
        {
            if (id == default) return;

            var dto = await _memberService.GetMemberAsync(id);
            if (dto == null)
            {
                _logger.LogError($"Could not find member with ID: {id}");
                return;
            }
            Member = new UpdateMemberModel()
            {
                Id = dto.Id,
                RowVersion = dto.RowVersion,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.PhoneNumber,
                RoleId = dto.RoleId
            };

            var allRoles = await _roleService.GetAllRolesAsync();
            if (!allRoles.Any())
            {
                _logger.LogError($"Could not find any roles in the union");
                return;
            }
            Roles.AddRange(allRoles.Select(dto => new Dictionary<Guid, string>
            {{ dto.Id, dto.RoleName}}));

            CurrentRole = Roles.FirstOrDefault(x => x.ContainsKey(dto.RoleId));
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            try
            {
                await _memberService.PutMemberAsync(new MemberUpdateRequestDto
                {
                    Id = Member.Id,
                    RowVersion = Member.RowVersion,
                    FirstName = Member.FirstName,
                    LastName = Member.LastName,
                    PhoneNumber = Member.Phone ?? "",
                    RoleId = Member.RoleId
                });
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
