using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class DetailsModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public DetailsModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public BookingUnit BookingUnit { get; set; } = default!;

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
    }
}
