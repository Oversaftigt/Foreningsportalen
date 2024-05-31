using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using Microsoft.AspNetCore.Authorization;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.Union;

namespace ForeningsPortalen.Website.Pages.Admin.Unions
{
    [Authorize(Policy = "AdministratorAccess")]
    public class CreateModel : PageModel
    {
        private readonly IUnionService _unionService;

        public CreateModel(IUnionService unionService)
        {
            _unionService = unionService;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CreateUnionModel Union { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var dto = new UnionCreateRequestDto() { unionName = Union.Name };
                await _unionService.PostUnionAsync(dto);

                return RedirectToPage("./Index");
            }

            return Page();
        }
    }
}
