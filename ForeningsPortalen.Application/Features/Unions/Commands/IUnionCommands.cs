using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Commands
{
    public interface IUnionCommands
    {
        void UpdateUnion(UnionCommandUpdateDto unionUpdateDto);
        void CreateUnion(UnionCommandCreateDto unionCreateDto);
        void DeleteUnion(Guid id);
    }
}
