using lab12.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12.Models
{
    public class AuthorsRepository : IRepository<Author>
    {
        private MyDb db;
        public AuthorsRepository(MyDb context)
        {
            this.db = context;
        }
        public IEnumerable<Author> GetAll()
        {
            return db.Author;
        }
        public Author Get(int id)
        {
            return db.Author.Find(id);
        }
        public void Create(Author worker)
        {
            db.Author.Add(worker);
        }
        public void Update(Author worker)
        {
            db.Entry(worker).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Author author = db.Author.Find(id);
            if(author != null)
            {
                db.Author.Remove(author);
            }
        }
    }
}
