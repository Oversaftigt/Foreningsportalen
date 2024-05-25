﻿using ForeningsPortalen.Website.Models.Booking;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class EditModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public EditModel(ForeningsPortalen.Website.Models.MyDbContext context)
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
            BookingIndexModel = bookingindexmodel;
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

            _context.Attach(BookingIndexModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingIndexModelExists(BookingIndexModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BookingIndexModelExists(Guid id)
        {
            return _context.BookingIndexModel.Any(e => e.Id == id);
        }
    }
}
