using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_continuacao.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_continuacao.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }
        public IList<Person> GetAll()
        {
            return context.People.Include(x=>x.City).ToList();
        }
        public void Save(Person entity)
        {
            //entity.City = context.Cities.Find(entity.City.Id);
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            context.SaveChanges();
            return true;
        }

        public Person GetById(int entityId)
        {
            return context.People.Include(x=>x.City).SingleOrDefault(x=>x.Id == entityId);
        }

        public void Update(Person entity)
        {
            
            context.People.Update(entity);
            context.SaveChanges();
        }
    }
}