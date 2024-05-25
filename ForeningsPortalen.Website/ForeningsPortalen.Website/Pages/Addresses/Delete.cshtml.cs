using ForeningsPortalen.Website.Models.Address;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Addresses
{
    public class DeleteModel : PageModel
    {


        public DeleteModel()
        {

        }

        [BindProperty]
        public DeleteAddressModel Address { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var address = 

            //if (address == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    Address = address;
            //}
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var address = await _context.Address.FindAsync(id);
            //if (address != null)
            //{
            //    Address = address;

            //}

            return RedirectToPage("./Index");
        }
    }
}
