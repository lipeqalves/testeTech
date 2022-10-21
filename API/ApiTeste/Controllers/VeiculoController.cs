using ApiTeste.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {

        [HttpGet()]
        public IEnumerable<Veiculo> Get()
        {
            return VeiculoLista.ToList();
        }
      
             public static List<Veiculo> VeiculoLista = new List<Veiculo>();

        [HttpPost()]
        public Veiculo Post([FromBody] Veiculo veiculo)
        {
            VeiculoLista.Add(veiculo);
            return veiculo;
        }
    }
}