using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ApiIndicadores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndicadoresController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Indicador> Get([FromServices] IndicadoresDAO _dao)
        {
            return _dao.Obter();
        }

        // GET api/indicadores/5
        [HttpGet("{id}")]
        public Indicador Get([FromServices] IndicadoresDAO _dao, string id)
        {
            return _dao.ObterPorId(id);
        }

        // POST api/indicadores
        [HttpPost]
        public void Post([FromServices] IndicadoresDAO _dao, Indicador indicador)
        {
            _dao.Incluir(indicador);
        }

        // PUT api/values/5
        [HttpPut("{sigla}")]
        public void Put([FromServices] IndicadoresDAO _dao, Indicador indicador)
        {
            _dao.Editar(indicador);
        }

        // DELETE api/values/5
        [HttpDelete("{sigla}")]
        public void Delete([FromServices] IndicadoresDAO _dao, string sigla)
        {
            _dao.Excluir(sigla);
        }
    }
}
