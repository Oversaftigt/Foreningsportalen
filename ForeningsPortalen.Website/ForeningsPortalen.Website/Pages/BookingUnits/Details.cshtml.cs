using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations;
using ForeningsPortalen.Website.Models.BookingUnit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class DetailsModel : PageModel
    {
        private readonly IBookingUnitService _bookingUnitService;

        public DetailsModel(IBookingUnitService bookingUnitService)
        {
            _bookingUnitService = bookingUnitService;
        }

        [BindProperty]
        public IndexBookingUnitModel BookingUnit { get; set; }

        [BindProperty]
        public IEnumerable<DateTime> AvailableDates { get; set; } = new List<DateTime>();

        public async Task OnGetAsync(Guid id, string bookingUnit)
        {
            //BookingUnit = bookingUnit;
            BookingUnit = JsonConvert.DeserializeObject<IndexBookingUnitModel>(System.Net.WebUtility.UrlDecode(bookingUnit));
            var dates = await _bookingUnitService.GetAvailableDatesForBookingUnit(id);

            if (dates is not null)
            {
                AvailableDates = dates;
            }
            
        }

        public string test()
        {
            return "Du har booket nu";
        }
    }
}
