using ForeningsPortalen.Website.Contract;
using ForeningsPortalen.Website.DTOs.Union;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ForeningsPortalen.Website.Pages.Admin.Union
{
    [Authorize(Policy = "AdministratorPolicy")]
    public class ChooseUnionModel : PageModel
    {
        private readonly IUnionService _unionService;

        public ChooseUnionModel(IUnionService unionService)
        {
            _unionService = unionService;
        }

        [BindProperty]
        public IEnumerable<UnionQueryResultDto> AllUnions { get; set; }

        [BindProperty]
        public UnionQueryResultDto SelectedUnion { get; set; }

        public async Task OnGet()
        {
            AllUnions = await _unionService.GetAllUnionsAsync();
        }
        //public IActionResult OnPost()
        //{
        //    var unionIdString = ChosenUnion.Id.ToString();
        //    HttpContext.Session.SetString("Union", $"{ChosenUnion.Id}");

        //    return Redirect("~/");
        //}
        public async Task<IActionResult> OnPostAsync()
        {

            if (SelectedUnion != null)
            {
                HttpContext.Session.SetString("Union", SelectedUnion.Id.ToString());

                return RedirectToPage("/Index", new { id = SelectedUnion.Id });
            }
            // If no union was selected, re-fetch unions and return to the page
            AllUnions = await _unionService.GetAllUnionsAsync();
            ModelState.AddModelError(string.Empty, "No union selected.");
            return Page();
        }
    }
}
