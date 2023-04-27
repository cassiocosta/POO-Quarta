// See https://aka.ms/new-console-template for more information
using aula10_interfaces;

Console.WriteLine("Hello, World!");



// Exemplo de uso
var loja = new Loja();
var roupa = new Roupa();
var calcado = new Calcado();
loja.AdicionarItem(roupa);
loja.AdicionarItem(calcado);
