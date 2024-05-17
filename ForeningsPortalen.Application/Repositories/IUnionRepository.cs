using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IUnionRepository
    {
        Union GetOneUnion(Guid id); //Skal denne ændres til GetUnionById
        void CreateUnion(Union union);
        void UpdateUnion();
        void DeleteUnion();

    }
}
