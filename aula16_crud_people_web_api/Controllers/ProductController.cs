using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aula16_crud_people_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return  null;
        }
    }
}