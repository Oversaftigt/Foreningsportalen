using System.ComponentModel.DataAnnotations;

namespace ForeningsPortalen.Domain.Shared;

public abstract class Entity(Guid id)
{
    [Timestamp]
    public byte[] RowVersion { get; private set; } = [];
    public Guid Id { get; init; } = id;
}
