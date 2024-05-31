using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Member;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.Members
{
    [Authorize(Policy = "AdministratorAccess")]

    public class EditModel : PageModel
    {


        public EditModel()
        {
        }

        [BindProperty]
        public UpdateMemberModel Member { get; set; } = default!;

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
            //Member = member;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(Member).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    //if (!MemberExists(Member.Id))
            //    //{
            //    //    return NotFound();
            //    //}
            //    //else
            //    //{
            //    //    throw;
            //    //}
            //}

            return RedirectToPage("./Index");
        }

        //private bool MemberExists(Guid id)
        //{
        //    return _context.Member.Any(e => e.Id == id);
        //}
    }
}
