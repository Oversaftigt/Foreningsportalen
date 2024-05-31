using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ForeningsPortalen.Website.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly ForeningsPortalen.Website.Models.MyDbContext _context;

        public IndexModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {
            _context = context;
        }

        public IList<Document> Document { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Document = await _context.Document.ToListAsync();
        }
    }
}
