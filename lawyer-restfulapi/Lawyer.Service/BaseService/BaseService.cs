using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using Lawyer.Repository.UnitOfWork;
using System.Collections.Generic;

namespace Lawyer.Service.BaseService
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected readonly IUnitOfWork<T> _unitOfWork;

        protected abstract IRepository<T> _repository { get; }

        public BaseService(IUnitOfWork<T> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Delete(int id)
        {
            T entity = _repository.Get(id);
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<T> GetAlls()
        {
            return _repository.GetAll();
        }

        public void Insert(T entity)
        {
            _repository.Insert(entity);
            _unitOfWork.Commit();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
