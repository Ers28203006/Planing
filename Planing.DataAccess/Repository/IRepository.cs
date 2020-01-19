using System.Collections.Generic;

namespace Planing.DataAccess.Repository
{
    public interface IRepository <T> where T:class
    {
        void Create(T item);
        T GetById(int id);
        IEnumerable<T> GetCollection();
        void Remove(T item);
        void Udate(T item);
    }
}
