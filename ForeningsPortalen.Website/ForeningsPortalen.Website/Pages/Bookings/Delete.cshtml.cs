using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Booking;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class DeleteModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public DeleteModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookingIndexModel BookingIndexModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingindexmodel = await _context.BookingIndexModel.FirstOrDefaultAsync(m => m.Id == id);

            if (bookingindexmodel == null)
            {
                return NotFound();
            }
            else
            {
                BookingIndexModel = bookingindexmodel;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingindexmodel = await _context.BookingIndexModel.FindAsync(id);
            if (bookingindexmodel != null)
            {
                BookingIndexModel = bookingindexmodel;
                _context.BookingIndexModel.Remove(BookingIndexModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
