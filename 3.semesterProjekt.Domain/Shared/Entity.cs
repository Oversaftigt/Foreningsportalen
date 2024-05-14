using System.ComponentModel.DataAnnotations;

namespace _3.semesterProjekt.Domain.Shared;

public abstract class Entity(Guid id)
{
    [Timestamp]
    public Byte[] RowVersion { get; private set; } = [];
    public Guid Id { get; init; } = id;
}
