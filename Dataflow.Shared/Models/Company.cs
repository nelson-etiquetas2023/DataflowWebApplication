using System.ComponentModel.DataAnnotations;

namespace Dataflow.Shared.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

    }
}
