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
            Name = title;
            Creator = uploadedBy;
            Date = date;
        }

        public Guid DocumentId { get; set; }
        public string Name { get; set; }
        public Member Creator { get; set; }
        public DateOnly Date { get; set; }
        public Union Union { get; set; }

        public static Document CreateDocument(string title, Member uploadedBy, DateOnly date)
        {
            if(title == null) { throw new ArgumentNullException(nameof( title )); }
            
            var newDocument = new Document(title, uploadedBy, date);

            return newDocument;
        }
   
    }
}
