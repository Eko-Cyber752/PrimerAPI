using Microsoft.AspNetCore.Mvc;
using PrimerAPI.Models;

namespace PrimerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpleadosController : Controller
    {
        private readonly DbEmpresaContext _context;

        public EmpleadosController(DbEmpresaContext ctx)
        {
            _context = ctx;
        }

        [HttpGet("ListarEmpleados")]
        public ActionResult<List<Empleado>> ListarEmpleados()
        {
            return _context.Empleados.ToList();
        }

        [HttpGet("ObtenerEmpleado/{id}")]
        public ActionResult<Empleado> ObtenerEmpleado(int id)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.IdEmpleados == id);
            if (empleado == null)
            {
                return NotFound();
            }
            return empleado;
        }

        [HttpPost("CrearEmpleado")]
        public ActionResult<Empleado> CrearEmpleado([FromBody] Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObtenerEmpleado), new { id = empleado.IdEmpleados }, empleado);
        }

        [HttpPut("ActualizarEmpleado/{id}")]
        public IActionResult ActualizarEmpleado(int id, [FromBody] Empleado empleado)
        {
            if (id != empleado.IdEmpleados)
            {
                return BadRequest();
            }

            _context.Entry(empleado).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                if (!_context.Empleados.Any(e => e.IdEmpleados == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
    }
}