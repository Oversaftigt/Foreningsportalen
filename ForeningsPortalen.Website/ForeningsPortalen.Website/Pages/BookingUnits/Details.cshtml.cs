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
        private readonly ICategoryService _categoryService;

        public DetailsModel(IBookingUnitService bookingUnitService, ICategoryService categoryService)
        {
            _bookingUnitService = bookingUnitService;
            _categoryService = categoryService;
        }

        [BindProperty]
        public IndexBookingUnitModel BookingUnit { get; set; }

        [BindProperty]
        public List<DateTime> AvailableDates { get; set; } = new List<DateTime>();

        [BindProperty]
        public List<DateTime> AvailableDatesEndTime { get; set; } = new List<DateTime>();

        [BindProperty]
        public string BookingDurationType { get; set; }

        public async Task OnGetAsync(Guid id, string bookingUnit)
        {
            //BookingUnit = bookingUnit;
            BookingUnit = JsonConvert.DeserializeObject<IndexBookingUnitModel>(System.Net.WebUtility.UrlDecode(bookingUnit));

            var category = await _categoryService.GetCategoriesById(BookingUnit.Category);
            BookingDurationType = category.ReservationLimitType;

            var dates = await _bookingUnitService.GetAvailableDatesForBookingUnit(id);

            if (dates is not null)
            {
                AvailableDates = dates.ToList();
            }

            if (BookingDurationType is "Hours")
            {
                foreach (var date in AvailableDates)
                {
                    AvailableDatesEndTime.Add(date.AddHours(BookingUnit.MaxBookingDuration));
                }
            }
            if (BookingDurationType is "Days")
            {
                foreach (var date in AvailableDates)
                {
                    AvailableDatesEndTime.Add(date.AddDays(BookingUnit.MaxBookingDuration));
                }
            }
        }

    }
}
