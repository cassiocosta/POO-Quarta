using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Person Person { get; set; }
    }
}