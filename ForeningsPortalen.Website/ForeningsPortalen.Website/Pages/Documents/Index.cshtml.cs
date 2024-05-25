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
    public class IndexModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public IndexModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Document> Document { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Document = await _context.Document.ToListAsync();
        }
    }
}
