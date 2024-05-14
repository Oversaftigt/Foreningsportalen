using System.ComponentModel.DataAnnotations;

namespace _3.semesterProjekt.Domain.Shared;

public class Entity(Guid id)
{
    [Timestamp]
    public Byte[] RowVersion { get; private set; } = [];
    public Guid Id { get; init; } = id;
}
