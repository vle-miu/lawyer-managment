using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;

namespace Lawyer.Repository.UserRepository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }

        public User GetUserByUserName(string username)
        {
            // TODO
            return null;
        }
    }
}
