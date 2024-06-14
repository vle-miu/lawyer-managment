using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using Lawyer.Repository.LawyerRepository;

namespace Lawyer.Repository.LawyerOfficeRepository
{
    public class LawyerOfficeRepository : Repository<LawyerOffice>, ILawyerOfficeRepository
    {
        public LawyerOfficeRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
