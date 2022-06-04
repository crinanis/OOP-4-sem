using lab12.Models;
using System.Data.Entity;


namespace lab12.Context
{
    public class MyDb : DbContext
    {
        public MyDb() : base("DBConnection") { }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
