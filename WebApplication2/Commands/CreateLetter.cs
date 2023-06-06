using WebApplication2.Enum;
using WebApplication2.Models;

namespace WebApplication2.Commands
{
    public class CreateLetter : BaseEntity
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string AgencyId { get; set; }
        public DateTime dateRecieved { get; set; }
        public IFormFile letter { get; set; }
        public int regionId { get; set; }
        public List<int> supportingDocument { get; set; }
        public string referenceNumber { get; set; }
        public string CaseTrackingGuid { get; set; }
        public LetterStatus letterstatus { get; set; }
        public ICollection<SupportingDocument> supportingDocuments { get; set; }
    }
}
