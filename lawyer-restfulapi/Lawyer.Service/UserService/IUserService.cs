
using Lawyer.DomainEntities;

namespace Lawyer.Service.UserService
{
    public interface IUserService : IBaseService<User>
    {
        User authentication(string username, string password);
    }
}
