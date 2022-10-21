using ApiTeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {

        [HttpGet()]
        public IEnumerable<Clientes> Get()
        {
            return ClientesLista.ToList();
        }

        public static List<Clientes> ClientesLista = new();

        [HttpPost()]
        public Clientes Post([FromBody] Clientes cliente)
        {
            ClientesLista.Add(cliente);
            return cliente;
        }
    }
}