using aula11_interfaces_exercicios.Exercicio01;
using aula11_interfaces_exercicios.Exercicio02;
Console.WriteLine("\n\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("-------Exercício 01----------");
Console.WriteLine("-----------------------------");

IPagamento cartao = new CartaoDeCredito(); 
IPagamento boleto = new Boleto(); 

var cliente1 = new Cliente(cartao);
cliente1.Comprar(50.0);

var cliente2 = new Cliente(boleto); 
cliente2.Comprar(1000);


Console.WriteLine("\n\n");
Console.WriteLine("-----------------------------");
Console.WriteLine("-------Exercício 02----------");
Console.WriteLine("-----------------------------");
// -----------------
var professor = new Professor{Nome = "Joao", Idade=40}; 
var aluno = new Aluno { Nome = "Maria", Idade = 20 }; 

var escola = new Escola(); 

escola.ApresentarPessoa(professor); 
escola.ApresentarPessoa(aluno);


Console.ReadKey();




