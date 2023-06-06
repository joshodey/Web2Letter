namespace WebApplication2.Commands
{
    public class SupportingDocumentRepo
    {
        public Task<bool> AddSupportingDocument()
        {
            return Task.FromResult(true);
        }

        public Task<bool> UpdateSupportingDocument()
        {
            return Task.FromResult(true);
        }

        public void DeleteDocument()
        {

        }

        public Task<CreateSupportingDocument> GetDocument(string Id)
        {
            return null;
        }



    }
}
