using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ForeningsPortalen.Website.Models;
using ForeningsPortalen.Website.Models.Category;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices;
using ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices.Implementations;
using Microsoft.AspNetCore.Authorization;

namespace ForeningsPortalen.Website.Pages.Admin.BookingCategories
{
    [Authorize(Policy = "AdministratorAccess")]

    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [BindProperty]
        public IList<IndexCategoryModel> IndexCategoryModel { get; set; } = new List<IndexCategoryModel>();
        
        public async Task OnGetAsync()
        {
            var activeUnionId = User.Claims.FirstOrDefault(x => x.Type == "UnionId").Value;
            if (activeUnionId != null)
            {
                var guidUnionId = Guid.Parse(activeUnionId);
                var categories = await _categoryService.GetCategoriesAsync(guidUnionId);

                if (categories != null)
                {
                    categories?.ToList().ForEach(dto => IndexCategoryModel.Add(new IndexCategoryModel
                    { Name = dto.CategoryName,
                        DurationType = dto.ReservationLimitType,
                        MaxBookingsOfThisCategory = dto.MaxBookings,
                        Id = dto.Id }));
                }
                else 
                {
                    Redirect("/error");
                    throw new Exception("There were no categories created in this union");
                
                }
                

            }
        }
    }
}
