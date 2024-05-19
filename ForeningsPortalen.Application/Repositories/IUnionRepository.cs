using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUnionRepository
    {
        Union GetUnion(Guid id); //Skal denne ændres til GetUnionById
        void AddUnion(Union union);
        void UpdateUnion(Union union, byte[] rowversion);
        void DeleteUnion(Union union, byte[] rowversion);
    }
}
