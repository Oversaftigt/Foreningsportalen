using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class EditModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public EditModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BookingUnit BookingUnit { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookingunit =  await _context.BookingUnit.FirstOrDefaultAsync(m => m.Id == id);
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
