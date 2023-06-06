using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class SupportingDocument: BaseEntity
    {
        public string Document { get; set; }
        [ForeignKey(nameof(Letter))]
        public string LetterId { get; set; }
    }
}
