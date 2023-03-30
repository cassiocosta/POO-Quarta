using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula04_encapsulamento
{
    public class LivroRepository
    {
        
        public static List<Livro> books = new List<Livro>();

        public List<Livro>GetAll()
        {
            return books;
        }
        public Livro GetById(int id)
        {
            return books.Find(li=>li.Id == id);
        }
        public List<Livro>GetbyContainName(string text)
        {
            return books.FindAll(x=>x.Titulo.Contains(text));
        }

        public void Create(Livro livro)
        {
            books.Add(livro);
        }

        public void Delete(int id)
        {
            //codio que vai no banco e deleta.            
        }
    }
}