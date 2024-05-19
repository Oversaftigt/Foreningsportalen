using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Repositories;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Categories.Commands.Implementations
{
    public class CategoryCommands : ICategoryCommands
    {
        private readonly ICategoryRepository _repo;

        public CategoryCommands(ICategoryRepository repo)
        {
            _repo = repo;
        }

        void ICategoryCommands.CreateCategory(AddressCreateRequestDto addressCreateRequestDto)
        {
            throw new NotImplementedException();
        }

        void ICategoryCommands.UpdateCategory(AddressUpdateRequestDto addressUpdateRequestDto)
        {
            throw new NotImplementedException();
        }

        void ICategoryCommands.DeleteCategory(SharedEntityDeleteDto deleteDto)
        {
            throw new NotImplementedException();
        }
    }
}
