﻿using System;
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

namespace ForeningsPortalen.Website.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public CreateModel(ICategoryService categoryService)
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
                var GuidUnionId = Guid.Parse(activeUnionId);
                var categories = await _categoryService.GetCategoriesAsync(GuidUnionId);

                if (categories != null)
                {
                    categories?.ToList().ForEach(dto => IndexCategoryModel.Add(new IndexCategoryModel
                    {
                        Name = dto.CategoryName,
                        DurationType = dto.ReservationLimitType,
                        MaxBookingsOfThisCategory = dto.MaxBookings,
                        Id = dto.Id
                    }));
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
