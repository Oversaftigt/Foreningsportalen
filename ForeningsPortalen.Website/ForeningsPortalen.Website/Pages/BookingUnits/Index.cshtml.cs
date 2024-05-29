using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class IndexModel : PageModel
    {
        private readonly IBookingUnitService _bookingUnitService;

        public IndexModel(IBookingUnitService bookingUnitService)
        {
            _bookingUnitService = bookingUnitService;
        }

        [BindProperty]
        public IList<BookingUnit> BookingUnits { get; set; } = default!;

        public async Task OnGetAsync()
        {
            throw new NotImplementedException();
        }
    }
}
