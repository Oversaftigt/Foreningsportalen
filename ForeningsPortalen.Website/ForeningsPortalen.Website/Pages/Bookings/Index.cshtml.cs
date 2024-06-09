using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Booking;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly IBookingService _bookingService;
        private readonly IMemberService _memberService;

        public IndexModel(IBookingService bookingService, IMemberService memberService)
        {
            _bookingService = bookingService;
            _memberService = memberService;
        }

        public List<BookingIndexModel> BookingIndexModel { get; set; } = new();

        public async Task OnGetAsync()
        {
            var currentMemberEmail = User.Identity.Name;
            if (currentMemberEmail is not null)
            {
                var member = await _memberService.GetMemberByEmailAsync(currentMemberEmail);

                var bookings = await _bookingService.GetBookingByMemberAsync(member.Id);

                if (bookings is not null)
                {
                    foreach (var booking in bookings)
                    {
                        BookingIndexModel.Add(new BookingIndexModel
                        {
                            Id = booking.Id,
                            BookingStart = booking.StartTime,
                            BookingEnd = booking.EndTime,
                            BookingUnits = booking.BookingUnitsIds,
                            CreationDate = booking.DateOfCreation,
                            Category = booking.CategoryName,
                            UserId = booking.UserId
                        }
                        );
                    }
                }
            }

        }
    }
}
