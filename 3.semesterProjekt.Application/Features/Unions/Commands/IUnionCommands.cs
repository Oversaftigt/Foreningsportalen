using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.semesterProjekt.Application.Features.Union.Commands.DTOs;

namespace _3.semesterProjekt.Application.Features.Unions.Commands
{
    public interface IUnionCommands
    {
        void UpdateUnion(UnionCommandUpdateDto unionUpdateDto);
        void CreateUnion(UnionCommandCreateDto unionCreateDto);
        void DeleteUnion(Guid id);
    }
}
