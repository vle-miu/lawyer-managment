using Lawyer.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Lawyer.Repository.BaseRepository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> filter);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
