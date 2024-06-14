using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using Lawyer.Repository.UnitOfWork;
using Lawyer.Service.BaseService;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Lawyer.Service.UserService
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUnitOfWork<User> unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<User> _repository => _unitOfWork.Repository;

        public User authentication(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            Expression<Func<User, bool>> FindUserByUsernameAndPasswordFilter()
            {
                return x => (x.UserName.Equals(username) && x.Password.Equals(password));
            }

            return _repository.Find(FindUserByUsernameAndPasswordFilter()).FirstOrDefault();
        }
    }
}
