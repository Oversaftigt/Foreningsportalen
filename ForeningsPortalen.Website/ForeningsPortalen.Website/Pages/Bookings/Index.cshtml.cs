using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Booking;

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {

        }

        public List<BookingIndexModel> BookingIndexModel { get;set; } = new();

        public async Task OnGetAsync()
        {
            
        }
    }
}
