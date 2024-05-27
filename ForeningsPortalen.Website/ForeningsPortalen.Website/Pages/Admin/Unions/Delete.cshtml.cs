using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using ForeningsPortalen.Website.Models;

namespace ForeningsPortalen.Website.Pages.Admin.Unions
{
    public class DeleteModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public DeleteModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UnionQueryResultDto UnionQueryResultDto { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionqueryresultdto = await _context.UnionQueryResultDto.FirstOrDefaultAsync(m => m.Id == id);

            if (unionqueryresultdto == null)
            {
                return NotFound();
            }
            else
            {
                UnionQueryResultDto = unionqueryresultdto;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unionqueryresultdto = await _context.UnionQueryResultDto.FindAsync(id);
            if (unionqueryresultdto != null)
            {
                UnionQueryResultDto = unionqueryresultdto;
                _context.UnionQueryResultDto.Remove(UnionQueryResultDto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
