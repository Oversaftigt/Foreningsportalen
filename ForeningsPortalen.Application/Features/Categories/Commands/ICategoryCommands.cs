using ForeningsPortalen.Application.Features.Categories.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Commands
{
    public interface ICategoryCommands
    {
        /// <summary>
        /// Create a category, using a dto
        /// </summary>
        /// <param name="categoryCreateRequestDto"></param>
        void CreateCategory(CategoryCreateRequestDto categoryCreateRequestDto);

        /// <summary>
        /// Update an existing category using a dto
        /// </summary>
        /// <param name="categoryUpdateRequestDto"></param>
        void UpdateCategory(CategoryUpdateRequestDto categoryUpdateRequestDto);

        /// <summary>
        /// Delete a category
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteCategory(SharedEntityDeleteDto deleteDto);

    }
}
