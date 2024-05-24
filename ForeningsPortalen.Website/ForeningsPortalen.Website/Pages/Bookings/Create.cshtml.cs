﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Booking;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public CreateModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BookingIndexModel BookingIndexModel { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BookingIndexModel.Add(BookingIndexModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}