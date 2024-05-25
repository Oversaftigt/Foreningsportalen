using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;

namespace ForeningsPortalen.Website.Pages.BookingUnits
{
    public class IndexModel : PageModel
    {


        public IndexModel(ForeningsPortalen.Website.Models.MyDbContext context)
        {

        }

        public IList<BookingUnit> BookingUnits { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (BookingUnits == null)
            {
                BookingUnits = new List<BookingUnit>();
            }
        }
    }
}
