using ForeningsPortalen.Domain.Shared;
using System.Reflection.Emit;

namespace ForeningsPortalen.Domain.Entities
{
    public class Document : Entity
    {
        public Document()
        {
        }

        public Document(string title, Member uploadedBy, DateOnly date)
        {
            Title = title;
            UploadedBy = uploadedBy;
            Date = date;
        }
        public Guid DocumentId { get; set; }
        public required string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }
   
    }
}
