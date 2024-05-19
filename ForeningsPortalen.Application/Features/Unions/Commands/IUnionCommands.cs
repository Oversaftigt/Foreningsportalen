using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Commands
{
    public interface IUnionCommands
    {
        void UpdateUnion(UnionCommandUpdateDto unionUpdateDto);
        void CreateUnion(UnionCommandCreateDto unionCreateDto);
        void DeleteUnion(SharedEntityDeleteDto deleteDto);
    }
}
