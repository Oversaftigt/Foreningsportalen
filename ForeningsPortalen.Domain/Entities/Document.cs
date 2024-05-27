using ForeningsPortalen.Domain.Shared;

namespace ForeningsPortalen.Domain.Entities
{
    public class Document : Entity
    {
        protected Document()
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

        public static Document CreateDocument(string title, Member uploadedBy)
        {
            if (title == null) { throw new ArgumentNullException(nameof(title)); }

            var documentCreeation = DateOnly.FromDateTime(DateTime.Now);
            var newDocument = new Document(title, uploadedBy, documentCreeation);

            return newDocument;
        }

    }
}
