using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using ForeningsPortalen.Application.Features.Categories.Commands.Interfaces;
using ForeningsPortalen.Application.Features.Categories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        void ICategoryCommands.DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
