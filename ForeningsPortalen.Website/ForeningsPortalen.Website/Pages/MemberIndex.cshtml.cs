using ForeningsPortalen.Website.DTOs.Member;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForeningsPortalen.Website.Pages
{
    public class MemberIndexModel : PageModel
    {
        public MemberIndexModel()
        {

        }

        [BindProperty]
        public IEnumerable<MemberQueryResultDto> AllMembers { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {


        }
    }
}
