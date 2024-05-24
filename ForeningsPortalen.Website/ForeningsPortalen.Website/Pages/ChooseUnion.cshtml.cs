using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using ForeningsPortalen.Website.DTOs.Union;
using ForeningsPortalen.WebApp.Contract;
using Microsoft.AspNetCore.Authorization;


namespace ForeningsPortalen.Website.Pages
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
        public UnionQueryResultDto ChosenUnion { get; set; }

        public async Task OnGet()
        {
            AllUnions = await _unionService.GetAllUnionsAsync();
        }
        public void OnPost()
        {
            var unionIdString = ChosenUnion.Id.ToString();
            HttpContext.Session.SetString("Union", $"{ChosenUnion.Id}");

            Redirect("~/");
        }
    }
}
