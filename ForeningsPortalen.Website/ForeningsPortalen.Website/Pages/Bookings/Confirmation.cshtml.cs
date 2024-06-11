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
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class ConfirmationModel : PageModel
    {
        private readonly IBookingService _bookingService;
        private readonly IMemberService _memberService;
        private readonly IBookingUnitService _bookingUnitService;

        public ConfirmationModel(IBookingService bookingService, IMemberService memberService, IBookingUnitService bookingUnitService)
        {
            _bookingService = bookingService;
            _memberService = memberService;
            _bookingUnitService = bookingUnitService;
        }

        [BindProperty]
        public IndexBookingUnitModel BookingUnit { get; set; }

        [BindProperty]
        public DateTime BookingStartTime { get; set; }

        [BindProperty]
        public DateTime BookingEndTime { get; set; }
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task OnGetAsync(Guid id, string startTime, string endTime)
        {
            BookingUnit = new();
            var bookingUnitDto = await _bookingUnitService.GetBookingUnitById(id);
            BookingUnit = new IndexBookingUnitModel()
            {
                Id = bookingUnitDto.Id,
                Name = bookingUnitDto.BookingUnitName,
                Category = bookingUnitDto.CategoryId,
                IsActive = bookingUnitDto.IsBookingUnitActive,
                Deposit = bookingUnitDto.AdvancePayment,
                Price = bookingUnitDto.Fee,
                MaxBookingDuration = bookingUnitDto.ReservationLimit,
                Bookings = bookingUnitDto.BookingIds,
                RowVersion = bookingUnitDto.RowVersion
            };
            BookingStartTime = DateTime.Now;

            if (DateTime.TryParse(startTime, out DateTime parsedStartTime))
            {
                BookingStartTime = parsedStartTime;
            }
            if (DateTime.TryParse(endTime, out DateTime parsedEndTime))
            {
                BookingEndTime = parsedEndTime;
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
                        StartTime = BookingStartTime,
                        EndTime = BookingEndTime,
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
