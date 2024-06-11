using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.Union;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Admin.Unions
{
    public class EditModel : PageModel
    {
        private readonly IUnionService _unionService;

        public EditModel(IUnionService unionService)
        {
            _unionService = unionService;
        }

        [BindProperty]
        public EditUnion CurrentUnion { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid id)
        {
            var union = await _unionService.GetUnionByIdAsync(id);

            CurrentUnion = new EditUnion
            {
                Id = union.Id,
                Name = union.Name,
                RowVersion = union.RowVersion,
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var unionUpdateRequest = new UnionUpdateRequestDto
            {
                id = CurrentUnion.Id,
                UnionName = CurrentUnion.Name,
                RowVersion = CurrentUnion.RowVersion
            };

            try
            {
                await _unionService.PutUnionAsync(unionUpdateRequest);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Kan ikke opdatere union, da en anden bruger har opdateret den i mellemtiden.");
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
