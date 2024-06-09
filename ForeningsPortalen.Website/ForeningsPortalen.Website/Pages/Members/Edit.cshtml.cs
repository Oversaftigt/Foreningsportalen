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

namespace ForeningsPortalen.Website.Pages.Members
{
    [Authorize(Policy = "AdministratorAccess")]

    public class EditModel : PageModel
    {
        private readonly ILogger _logger;
        private readonly IMemberService _memberService;

        public EditModel(ILogger logger, IMemberService memberService)
        {
            _logger = logger;
            _memberService = memberService;
        }

        [BindProperty]
        public UpdateMemberModel Member { get; set; } = default!;

        public async Task OnGetAsync(Guid id)
        {
            if (id == default) return;

            var dto = await _memberService.GetMemberByIdAsync(id);

            if (dto != null)
            {
                Member = new UpdateMemberModel()
                { Id = dto.Id, RowVersion = dto.RowVersion, FirstName = dto.FirstName, 
                 LastName = dto.LastName, Phone = dto.PhoneNumber};
            }

            _logger.LogError($"Could not find member with ID: {id}");
            return;
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
                    PhoneNumber = Member.Phone, //TODO test this
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

        //private bool MemberExists(Guid id)
        //{
        //    return _context.Member.Any(e => e.Id == id);
        //}
    }
}
