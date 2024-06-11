using ForeningsPortalen.Application.Features.Unions.Commands.DTOs;
using ForeningsPortalen.Application.Shared.DTOs;

namespace ForeningsPortalen.Application.Features.Unions.Commands
{
    public interface IUnionCommands
    {
        /// <summary>
        /// Update an existing union
        /// </summary>
        /// <param name="unionUpdateDto"></param>
        void UpdateUnion(UnionCommandUpdateDto unionUpdateDto);

        /// <summary>
        /// Create a new unuion
        /// </summary>
        /// <param name="unionCreateDto"></param>
        void CreateUnion(UnionCommandCreateDto unionCreateDto);

        /// <summary>
        /// Delete a union
        /// </summary>
        /// <param name="deleteDto"></param>
        void DeleteUnion(SharedEntityDeleteDto deleteDto);
    }
}
