using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T obj);
        void Update(T obj, int id);
        void Delete(object id);
        void Save();
    }
}
