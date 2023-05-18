

// // Create
using aula12_ef_continuacao.Data.Repositories;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
using aula14_ef_one_to_many.Domain.Entities;

var db = new DataContext();

var personRepository = new PersonRepository(db);

// listPeople();

// var vanessaChange = personRepository.GetById(4);
// vanessaChange.Name = "Vanessa Cardoso Teste ";
// vanessaChange.phoneNumber = "5566666666444";
// vanessaChange.City.Id = 1;

// personRepository.Update(vanessaChange);

listPeople();


//personRepository.Save(new Person { Name="Norton",phoneNumber="94949494949", City = new City{Name="Ararangua"}});

//personRepository.Save(new Person { Name="Leticia",phoneNumber="3434", City = new City { Id = 3}});


//listPeople();

void listPeople()
{
    Console.WriteLine("listing people");
    var people = personRepository.GetAll();

    foreach (var item in people)
    {
        var mostraCidade = item.City == null ? "Sem Cidade" : item.City.Name;
        Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} | Fone: {item.phoneNumber} Cidade: { mostraCidade }");
    }
}