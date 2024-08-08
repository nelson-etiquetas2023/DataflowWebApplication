using Dataflow.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DataFlow.Server.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {   
        }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<Company> company { get; set; }
        public DbSet<Parameter> parameter { get; set; }
    }
}
