using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
    }
}
