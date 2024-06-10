using ForeningsPortalen.Domain.Entities;

namespace ForeningsPortalen.Application.Repositories
{
    public interface IDocumentRepository
    {
        /// <summary>
        /// Add a new document to the database
        /// </summary>
        /// <param name="doocument"></param>
        void AddDocument(Document doocument);

        /// <summary>
        /// Update an existing document in the database
        /// </summary>
        /// <param name="document"></param>
        /// <param name="rowversion"></param>
        void UpdateDocument(Document document, byte[] rowversion);

        /// <summary>
        /// Delete a document
        /// </summary>
        /// <param name="document"></param>
        /// <param name="rowversion"></param>
        void DeleteDocument(Document document, byte[] rowversion);

        /// <summary>
        /// Get a specific document by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Document GetDocument(Guid id);

        ///// <summary>
        ///// Get a list of all documents
        ///// </summary>
        ///// <returns></returns>
        // List<Document> GetAllDocuments();
    }
}
