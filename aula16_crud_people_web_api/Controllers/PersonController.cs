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

        [HttpPost]
        public void Post(Person item)
        {
            _repository.Save(item);
        }
    }
}