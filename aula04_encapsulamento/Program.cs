
// instanciar um objeto livro de BD

using aula04_encapsulamento;

Livro livro = new Livro(12,"343434","BD");
Livro livro1 = new Livro(21,"343434353353","LPO",99);
Livro livro2 = new Livro(23,"99999999","LPOII",111);
Livro livro3 = new Livro(23,"10101010110","AP1"); 

LivroRepository repository = new LivroRepository();

repository.Create(livro);
repository.Create(livro1);
repository.Create(livro2);
repository.Create(livro3);


foreach (var item in repository.GetAll())
{
    Show($"O livro é: {item.Titulo} e o ISBN é {item.Isbn}");    
}





for (int i = 0; i < LivroRepository.books.Count; i++)
{
    if(LivroRepository.books[i].Id==2)
        Show(LivroRepository.books[i].Titulo);
}

foreach (var item in LivroRepository.books)
{
    if(item.Id==2)
        Show(item.Titulo);
}

Show(LivroRepository.books.Find(livro=>livro.Id==2).Titulo);

//O livro é: BD2 e o ISBN é 03030303030
void Show(string texto)
{
    Console.WriteLine(texto);
}

var result = repository.GetbyContainName("fa");

var operador =  Console.ReadLine();
while(Convert.Int32(operador)!=0)
{

}


public void Cadastrar()
{
    
}