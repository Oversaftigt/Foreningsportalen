﻿using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.BookingUnit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    [Authorize(Policy = "AdministratorAccess")]

    public class EditModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public EditModel(ForeningsPortalen.Website.Models.MyDbContext context)
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
            BookingUnit = bookingunit;
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

            _context.Attach(BookingUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingUnitExists(BookingUnit.Id))
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

        private bool BookingUnitExists(Guid id)
        {
            return _context.BookingUnit.Any(e => e.Id == id);
        }
    }
}
