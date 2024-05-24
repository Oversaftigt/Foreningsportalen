using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;

namespace ForeningsPortalen.Website.Pages.Members
{
    public class IndexModel : PageModel
    {

        public IndexModel()
        {

        }

        public IList<Member> Members { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (Members == null)
            {
                Members = new List<Member>();
            }
        }
    }
}
