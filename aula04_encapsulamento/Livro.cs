namespace aula04_encapsulamento
{
    public class Livro
    {
        public string Isbn { get; private set; }
        public int Id {get; private set;}
        public string Titulo { get; private set; }
        public double Preco { get; set; }

        public DateTime DataLancamento { get; set; }

        public Livro(int id, string isbn, string titulo, double preco = 0)
        {
            this.Id = id;
            this.Isbn= isbn;
            this.Titulo = titulo;
            this.Preco = preco;
        }
    }
}