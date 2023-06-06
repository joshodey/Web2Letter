using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Models;

namespace WebApplication2.Commands
{
    public class CreateSupportingDocument
    {

        public string Document { get; set; }
        public string LetterId { get; set; }
    }
}
