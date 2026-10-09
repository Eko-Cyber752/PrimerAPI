using Microsoft.AspNetCore.Mvc;
using PrimerAPI.Models;

namespace PrimerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private readonly DbEmpresaContext _context;
        public ClientesController(DbEmpresaContext ctx)
        {
            _context = ctx;
        }

        [HttpGet("ListarUsuarios")]
        public ActionResult<List<Cliente>> ListarClientes()
        {
            return _context.Clientes.ToList();
        }

        [HttpGet("ObtenerUsuario/{id}")]
        public ActionResult<Cliente> ObtenerUsuario(int id)
        {
            return _context.Clientes.FirstOrDefault(e => e.IdClientes == id);
        }
    }
}
