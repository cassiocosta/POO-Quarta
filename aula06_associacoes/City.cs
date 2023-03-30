using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06_associacoes
{
    public class City
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public City(int id, string nome)
        {
            this.Id=id;
            this.Nome = nome;
        }
    }
}