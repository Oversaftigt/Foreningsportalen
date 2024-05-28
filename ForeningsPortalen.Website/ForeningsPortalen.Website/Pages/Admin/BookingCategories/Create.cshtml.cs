using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Category;
using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;

namespace ForeningsPortalen.Website.Pages.Admin.BookingCategories
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public CreateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [BindProperty]
        public CreateCategoryModel CreateCategoryModel { get; set; } = default!;
        [BindProperty]
        public List<Dictionary<string,string>> ReservationType { get; set; } = new List<Dictionary<string,string>>();
        public IActionResult OnGet()
        {
            ReservationType.Add(new Dictionary<string, string> { { "Time Reservation", "Hours" } });
            ReservationType.Add(new Dictionary<string, string> { { "Dags Reservation", "Days" } });
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var unionId = User.Claims.FirstOrDefault(x => x.Type == "UnionId").Value;
            if (unionId is not null)
            {
                var guidUnionId = Guid.Parse(unionId);

                var dto = new CategoryCreateRequestDto
                {
                    CategoryName = CreateCategoryModel.Name,
                    ReservationLimitType = CreateCategoryModel.DurationType,
                    MaxBookings = CreateCategoryModel.MaxBookingsOfThisCategory,
                    UnionId = guidUnionId
                };

                await _categoryService.PostCategoryAsync(dto);
            }

            return RedirectToPage("./Index");
        }
    }
}
