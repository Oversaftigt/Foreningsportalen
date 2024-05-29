using ForeningsPortalen.Website.Models.BookingUnit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class DeleteModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public DeleteModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IndexBookingUnitModel BookingUnit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingunit = await _context.BookingUnit.FirstOrDefaultAsync(m => m.Id == id);

            if (bookingunit == null)
            {
                return NotFound();
            }
            else
            {
                BookingUnit = bookingunit;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingunit = await _context.BookingUnit.FindAsync(id);
            if (bookingunit != null)
            {
                BookingUnit = bookingunit;
                _context.BookingUnit.Remove(BookingUnit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
