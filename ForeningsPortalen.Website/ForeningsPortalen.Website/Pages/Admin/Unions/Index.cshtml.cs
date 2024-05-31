using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Union;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.HelperServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Models.Union;
using Microsoft.AspNetCore.Authorization;

namespace ForeningsPortalen.Website.Pages.Admin.Unions
{
    [Authorize(Policy = "AdministratorAccess")]
    public class IndexModel : PageModel
    {
        private readonly IUnionService _unionService;
        private readonly IUserClaimsService _userClaimsService;
        private readonly ILogger<ChooseUnionModel> _logger;

        public IndexModel(ILogger<ChooseUnionModel> logger, IUnionService unionService, IUserClaimsService userClaimsService)
        {
            _unionService = unionService;
            _userClaimsService = userClaimsService;
            _logger = logger;
        }
        [BindProperty]
        public List<IndexUnion> Unions { get; set; } = new();

        public IndexUnion SelectedUnion { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var allUnions = await _unionService.GetAllUnionsAsync();
            if (allUnions == null)
            {
                return RedirectToPage("./Create");
            }
            else
            {
                allUnions?.ToList().ForEach(dto => Unions.Add(new IndexUnion
                { Name = dto.Name, Id = dto.Id }));
                
                return Page();
            }
        }
    }
}