using aula02_classe_objeto_construtor_metodos;

Livro livroBD = new Livro(2323,"e939393939", "Banco de dados filosófico",240);


livroBD.Preco = 290;
Show(livroBD.Id + "-" + livroBD.Isbn + " - " + livroBD.Preco);

Show("digite algo:");
var retorno = Console.ReadLine();

Show("o usuário retornou " + retorno);

Show("digite um número: ");
double num1 = Convert.ToDouble( Console.ReadLine());

Show("digite mais um número: ");
double num2 = Convert.ToDouble( Console.ReadLine());

Calculadora calcDoCassio = new Calculadora();
var result = calcDoCassio.Calcular(num1,num2,"+");

Show("a soma é " + result);


void Show(string msg)
{
    Console.WriteLine(msg);
}


