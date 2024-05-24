using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;

namespace ForeningsPortalen.Website.Pages.Documents
{
    public class DetailsModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public DetailsModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public Document Document { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var document = await _context.Document.FirstOrDefaultAsync(m => m.Id == id);
            if (document == null)
            {
                return NotFound();
            }
            else
            {
                Document = document;
            }
            return Page();
        }
    }
}
