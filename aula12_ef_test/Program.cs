// See https://aka.ms/new-console-template for more information
using aula12_ef_test.Data;

var db = new DataContext();
Console.WriteLine($"Database path: {db.DbPath}.");