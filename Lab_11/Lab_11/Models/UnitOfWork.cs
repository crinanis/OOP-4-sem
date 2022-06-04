using lab12.Context;
using System;

namespace lab12.Models
{
    public class UnitOfWork : IDisposable
    {
        private MyDb db = new MyDb();
        private AuthorsRepository authorRepository;
        private BookRepository bookRepository;

        public AuthorsRepository Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorsRepository(db);
                return authorRepository;
            }
        }

        public BookRepository Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(db);
                return bookRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
