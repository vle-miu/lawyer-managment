using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;

namespace Lawyer.Repository.UserRepository
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUserName(string username);
    }
}
