using System.ComponentModel.DataAnnotations;

namespace Dataflow.Shared.Models
{
    public class Producto
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = null!;
    }
}
