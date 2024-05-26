using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.Members
{
    [Authorize(Policy = "AdministratorPolicy")]
    public class DeleteModel : PageModel
    {


        public DeleteModel()
        {
        }

        [BindProperty]
        public IndexMemberModel Member { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var member = await _context.Member.FirstOrDefaultAsync(m => m.Id == id);

            //if (member == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    Member = member;
            //}
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var member = await _context.Member.FindAsync(id);
            //if (member != null)
            //{
            //    Member = member;
            //    _context.Member.Remove(Member);
            //    await _context.SaveChangesAsync();
            //}

            return RedirectToPage("./Index");
        }
    }
}
