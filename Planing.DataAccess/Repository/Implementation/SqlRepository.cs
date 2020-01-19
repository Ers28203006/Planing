using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Planing.DataAccess.Repository.Implementation
{
    public class SqlRepository<T> : IRepository<T> where T : class
    {
        DbContext _context;
        DbSet<T> _db;
        public SqlRepository(DbContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }
        public void Create(T item)
        {
            _db.Add(item);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _db.Find(id);
        }

        public IEnumerable<T> GetCollection()
        {
            return _db.ToList();
        }

        public void Remove(T item)
        {
            _db.Remove(item);
            _context.SaveChanges();
        }

        public void Udate(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
