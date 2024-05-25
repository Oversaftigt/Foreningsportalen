using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            //var isAdmin = User.IsInRole("Administrator");
            //if (isAdmin)
            //{
            //    var sessionValue = HttpContext.Session.GetString("UnionId");
            //    if (sessionValue == null)
            //    {
            //        return RedirectToPage("/ChooseUnion");
            //    }
            //}
            //else
            //{
            //    var sessionValue = HttpContext.Session.GetString("UnionId");
            //    if (sessionValue == null)
            //    {
            //        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            //        return RedirectToPage("/LogoutPage");
            //    }
            //}

            return Page();
        }

        public void OnPost()
        {

        }

    }
}
