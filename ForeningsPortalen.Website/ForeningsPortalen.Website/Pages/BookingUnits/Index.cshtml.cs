using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class IndexModel : PageModel
    {


        public IndexModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {

        }

        public IList<BookingUnit> BookingUnits { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (BookingUnits == null)
            {
                BookingUnits = new List<BookingUnit>();
            }
        }
    }
}
