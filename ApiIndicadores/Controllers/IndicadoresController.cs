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
        public IEnumerable<Indicador> Get([FromServices]IndicadoresDAO _dao)
        {
            return _dao.Obter();
        }

        // GET api/indicadores/5
        [HttpGet("{id}")]
        public Indicador Get([FromServices]IndicadoresDAO _dao, string id)
        {
            return _dao.ObterPorId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
