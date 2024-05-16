using ForeningsPortalen.Application.Features.Addresses.Commands.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Categories.Commands.Interfaces
{
    public interface ICategoryCommands
    {
        void CreateCategory(AddressCreateRequestDto addressCreateRequestDto);
        void UpdateCategory(AddressUpdateRequestDto addressUpdateRequestDto);
        void DeleteCategory(Guid id);

    }
}
