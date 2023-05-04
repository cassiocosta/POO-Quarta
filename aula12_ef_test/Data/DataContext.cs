
using aula12_ef_test.Domain;
using Microsoft.EntityFrameworkCore;

namespace aula12_ef_test.Data
{
    public class DataContext : DbContext
    {
       public string DbPath { get; }

        public DataContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "TestEf.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}