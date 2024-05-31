using ForeningsPortalen.Application.Features.Categories.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Commands
{
    public interface ICategoryCommands
    {
        void CreateCategory(CategoryCreateRequestDto categoryCreateRequestDto);
        void UpdateCategory(CategoryUpdateRequestDto categoryUpdateRequestDto);
        void DeleteCategory(SharedEntityDeleteDto deleteDto);

    }
}
