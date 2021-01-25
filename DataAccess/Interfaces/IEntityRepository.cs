using Entities;
using System.Collections.Generic;

namespace DataAccess
{

    public interface IEntityRepository<T> where T : IEntity, new() //class => reference type

    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}