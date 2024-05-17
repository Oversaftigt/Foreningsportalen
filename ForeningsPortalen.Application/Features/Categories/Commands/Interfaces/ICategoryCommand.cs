using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Commands.Interfaces
{
    public interface ICategoryCommand
    {
        void CreateCategory(AddressCreateRequestDto addressCreateRequestDto);
        void UpdateCategory(AddressUpdateRequestDto addressUpdateRequestDto);
        void DeleteCategory(Guid id);

    }
}
