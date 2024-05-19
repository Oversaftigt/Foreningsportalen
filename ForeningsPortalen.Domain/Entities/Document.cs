using ForeningsPortalen.Domain.Shared;
using System.Reflection.Emit;

namespace ForeningsPortalen.Domain.Entities
{
    public class Document : Entity
    {
        public Document(Guid id) : base(id)
        {
        }

        public Document(Guid id, string title, Member uploadedBy, DateOnly date) : base(id)
        {
            Title = title;
            UploadedBy = uploadedBy;
            Date = date;
        }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }
   
    }
}
