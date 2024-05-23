using ForeningsPortalen.Domain.Shared;
using System.Reflection.Emit;

namespace ForeningsPortalen.Domain.Entities
{
    public class Document : Entity
    {
        public Document()
        {
        }
   
        internal Document(string title, Member uploadedBy, DateOnly date)
        {
            Title = title;
            UploadedBy = uploadedBy;
            Date = date;
        }

        public Guid DocumentId { get; set; }
        public string Title { get; set; }
        public Member UploadedBy { get; set; }
        public DateOnly Date { get; set; }

        public static Document CreateDocument(string title, Member uploadedBy, DateOnly date)
        {
            if(title == null) { throw new ArgumentNullException("Title not found"); }
            
            var newDocument = new Document(title, uploadedBy, date);

            return newDocument;
        }
   
    }
}
