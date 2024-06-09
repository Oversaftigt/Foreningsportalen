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
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Booking;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class ConfirmationModel : PageModel
    {
        private readonly IBookingService _bookingService;
        private readonly IMemberService _memberService;

        public ConfirmationModel(IBookingService bookingService, IMemberService memberService)
        {
            _bookingService = bookingService;
            _memberService = memberService;
        }

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

        public async Task<IActionResult> OnPostAsync()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}
            try
            {

                var currentMemberEmail = User.Identity.Name;
                if (currentMemberEmail != null)
                {
                    var member = await _memberService.GetMemberByEmailAsync(currentMemberEmail.ToString());

                    BookingCreateRequestDto booking = new BookingCreateRequestDto()
                    {
                        DateOfCreation = DateTime.Now,
                        StartTime = BookingStartTime.Date,
                        EndTime = BookingStartTime.Date.AddDays(1),
                        BookingUnitsID = new List<Guid>{ BookingUnit.Id },
                        UserId = member.Id,
                    };

                    await _bookingService.PostBookingAsync(booking);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "Kan ikke oprette booking");
                return Page();
                
            }

            return RedirectToPage("./Index");
        }
    }
}
