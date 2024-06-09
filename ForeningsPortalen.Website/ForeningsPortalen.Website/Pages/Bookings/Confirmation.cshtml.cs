using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Booking;
using ForeningsPortalen.Website.Models.BookingUnit;
using Newtonsoft.Json;
using System.Net;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class ConfirmationModel : PageModel
    {
        public ConfirmationModel()
        {

        }
        [BindProperty]
        public string teststring { get; set; } = "Test";

        [BindProperty]
        public IndexBookingUnitModel BookingUnit { get; set; }

        [BindProperty]
        public DateTime BookingStartTime { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task OnGetAsync(string bookingUnit, string startTime)
        {
            BookingUnit = new();
            if (bookingUnit != null)
            {
                BookingUnit = JsonConvert.DeserializeObject<IndexBookingUnitModel>(System.Net.WebUtility.UrlDecode(bookingUnit));
            }
            BookingStartTime = DateTime.Now;
            if (DateTime.TryParse(WebUtility.UrlDecode(startTime), out DateTime parsedStartTime))
            {
                BookingStartTime = parsedStartTime;
            }


        }

        public void test()
        {
            teststring = "fjweigjef";
        }
    }
}
