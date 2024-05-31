using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.Members
{
    public class DetailsModel : PageModel
    {
        
        public DetailsModel()
        {

        }

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
    }
}
