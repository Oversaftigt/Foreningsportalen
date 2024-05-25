using ForeningsPortalen.Website.Models.Booking;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
        }

        public IList<BookingIndexModel> BookingIndexModel { get; set; } = default!;

        public async Task OnGetAsync()
        {
            //BookingIndexModel = await _context.BookingIndexModel.ToListAsync();
        }
    }
}
