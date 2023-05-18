using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula14_ef_one_to_many.Domain.Entities;

namespace aula12_ef_test.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public City City { get; set; }
    }
}