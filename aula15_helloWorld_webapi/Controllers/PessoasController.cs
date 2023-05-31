using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aula15_helloWorld_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoasController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<string> Get()
        {
            // Exemplo de lista de pessoas
            var pessoas = new List<string>
            {
                "João",
                "Maria",
                "Pedro"
            };

            return pessoas;
        }
    }

}