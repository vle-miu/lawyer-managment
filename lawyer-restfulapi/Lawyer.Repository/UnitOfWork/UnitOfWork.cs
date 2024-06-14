using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using System;

namespace Lawyer.Repository.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : BaseEntity
    {
        private ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Repository = new Repository<T>(context);
        }

        public IRepository<T> Repository { get; private set; }

        public void Commit()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
