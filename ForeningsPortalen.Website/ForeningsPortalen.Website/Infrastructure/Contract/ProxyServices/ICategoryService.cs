﻿using ForeningsPortalen.Website.Infrastructure.Contract.DTOs.Category;

namespace ForeningsPortalen.Website.Infrastructure.Contract.ProxyServices
{
    public interface ICategoryService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryCreateRequest"></param>
        /// <returns></returns>
        Task PostCategoryAsync(CategoryCreateRequestDto categoryCreateRequest);

        Task<IEnumerable<CategoryQueryResultDto>> GetCategoriesAsync(Guid unionId);


    }
}
