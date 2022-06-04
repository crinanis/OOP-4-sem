using lab12.Context;
using System.Collections.Generic;
using System.Data.Entity;

namespace lab12.Models
{
    public class BookRepository : IRepository<Book>
    {
        private MyDb db;
        public BookRepository(MyDb context)
        {
            this.db = context;
        }
        public IEnumerable<Book> GetAll()
        {
            return db.Book;
        }
        public Book Get(int id)
        {
            return db.Book.Find(id);
        }
        public void Create(Book book)
        {
            db.Book.Add(book);
        }
        public void Update(Book book)
        {
            db.Entry(book).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Book book = db.Book.Find(id);
            if (book != null)
            {
                db.Book.Remove(book);
            }
        }
    }
}
