using ForeningsPortalen.Website.Models.Booking;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class DetailsModel : PageModel
    {


        public DetailsModel()
        {

        }

        public BookingIndexModel BookingIndexModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var bookingindexmodel = await _context.BookingIndexModel.FirstOrDefaultAsync(m => m.Id == id);
            //if (bookingindexmodel == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    BookingIndexModel = bookingindexmodel;
            //}
            return Page();
        }
    }
}
