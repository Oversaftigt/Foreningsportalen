using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Members
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {

        }

        public IList<Member> Members { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (Members == null)
            {
                Members = new List<Member>();
            }
        }
    }
}
