using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataflow.Shared.Models
{
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; } = null!;    
        public string Email { get; set; }= null!;
        public string Password { get; set; } = null!;
        public string TypeUser { get; set; } = null!;
        public string Departament { get; set; } = null!;
        public bool Active { get; set; }

    }
}
