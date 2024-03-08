using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TareaAPI.Models;

namespace TareaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecaudacionController : ControllerBase
    {
        private static List<Cliente> _clientes = new List<Cliente>
        {
            new Cliente { ID = 1, Nombre = "Juan", MontoPendiente = 100.50M },
            new Cliente { ID = 2, Nombre = "Maria", MontoPendiente = 50.20M },
        };

        [HttpGet]
        public IEnumerable<Cliente> GetAllClientes()
        {
            return _clientes;
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            var cliente = _clientes.FirstOrDefault(c => c.ID == id);

            if (cliente != null)
                return Ok(cliente.MontoPendiente);
            else
                return NotFound();
        }
    }
}