using ForeningsPortalen.Domain.Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ForeningsPortalen.Domain.Entities
{
    public class Document : Entity
    {
        public Document()
        {
        }

        internal Document(Member creator, string fileName, string filePath, byte[] docContent, DateOnly date, string extension)
        {
            Member = creator;
            FileName = fileName;
            FilePath = filePath;
            DocContent = docContent;
            Date = date;
            FileExtension = extension;
        }

        public Guid DocumentId { get; set; }
        public Member Member { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte[] DocContent { get; set; }
        public DateOnly Date { get; set; }
        public Union Union { get; set; }
        public string FileExtension { get; set; }


        public static Document CreateDocument(Member uploadedBy, string documentName, string filePath)
        {
            if (documentName == null) { throw new ArgumentNullException(nameof(documentName)); }
            if (filePath == null) {throw new ArgumentNullException(nameof(filePath)); }

            var documentCreation = DateOnly.FromDateTime(DateTime.Now);
            var docConvertedToByte = ConvertDocumentToByte(filePath);
            if (docConvertedToByte == null)
            {
                throw new ArgumentNullException(nameof(docConvertedToByte));
            }

            var extension = Path.GetExtension(filePath);
            var newDocument = new Document(uploadedBy, documentName, filePath, docConvertedToByte, documentCreation, extension);

            return newDocument;
        }

        private static byte[] ConvertDocumentToByte(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                var docInByte = new byte[stream.Length];
                stream.Read(docInByte);
                return docInByte;
            }
        }

    }
}
