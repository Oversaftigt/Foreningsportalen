using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public CreateModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Document Document { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Document.Add(Document);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
