using Dataflow.Shared.Models;
using DataFlow.Server.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace DataFlow.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        public AppDbContext _context { get; }
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsersAll() 
        {
            var users = _context.usuario.ToList();
            return Ok(users);
        }
        
    }
}
