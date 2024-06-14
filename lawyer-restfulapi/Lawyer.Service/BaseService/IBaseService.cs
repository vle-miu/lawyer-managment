using Lawyer.DomainEntities;
using System;
using System.Collections.Generic;

namespace Lawyer.Service
{
    public interface IBaseService<T> where T : BaseEntity 
    {
        IEnumerable<T> GetAlls();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
