using System.ComponentModel.DataAnnotations;

namespace _3.semesterProjekt.Domain.Shared;

public class Entity
{
    [Timestamp]
    public DateTime RowVersion { get; set; }
    public Guid Id { get; set; }
}
