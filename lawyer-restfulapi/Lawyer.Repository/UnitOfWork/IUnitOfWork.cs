using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using System;

namespace Lawyer.Repository.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T : BaseEntity
    {
        IRepository<T> Repository { get; }
        void Commit();
    }
}
