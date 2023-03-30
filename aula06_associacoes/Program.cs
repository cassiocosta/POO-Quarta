
using aula06_associacoes;

City city = new City(11,"Torres");


Pessoa obj = new Pessoa(12,"amanda",city);

obj.AddEndereco(new Endereco(1,"av. sivva jarim, 227"));

foreach (var item in obj.Enderecos)
{
    
}
PessoaFisica fisica = new PessoaFisica(1212,"Silva",city,"3939393993");

