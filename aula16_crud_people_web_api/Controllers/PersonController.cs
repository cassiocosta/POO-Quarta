using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Data.Repositories;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace aula16_crud_people_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repository;

        public PersonController()
        {
            _repository = new PersonRepository();
        }
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _repository.GetAll();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.GetById(id);
            if(item == null)
                return Ok(new {statusCode = 400, message="Nada foi encontrado com o id " + id,item});
            else
                return Ok(new {statusCode = 200, message="OK",item});
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person item)
        {
            _repository.Save(item);
            return Ok(new {
                statusCode = 200,
                message = "Cadastrado com sucesso.",
                item});
        }

        [HttpPut]
        public IActionResult Put([FromBody]Person item)
        {
            _repository.Update(item);
            return Ok(new {
                statusCode = 200,
                message = "Person autalizado com sucesso.",
                item});
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if(_repository.Delete(id))
                return Ok(new {statusCode=200,message="Deletado com sucesso"});
            else
                return Ok(new {statusCode=500,message="Ops!! Algo deu errado... tente novamente."});
        }


    }
}