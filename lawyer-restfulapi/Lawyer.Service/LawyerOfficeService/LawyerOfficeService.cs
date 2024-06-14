using Lawyer.DomainEntities;
using Lawyer.Repository.BaseRepository;
using Lawyer.Repository.UnitOfWork;
using Lawyer.Service.BaseService;
using System.Collections.Generic;

namespace Lawyer.Service.LawyerOfficeService
{
    public class LawyerOfficeService : BaseService<LawyerOffice>, ILawyerOfficeService
    {
        public LawyerOfficeService(IUnitOfWork<LawyerOffice> unitOfWork) : base(unitOfWork)
        {
        }

        protected override IRepository<LawyerOffice> _repository => _unitOfWork.Repository;

        public IEnumerable<LawyerOffice> GetNearestLawyerOffices(double latitude, double longtitude)
        {
            // TODO

            /*Expression<Func<LawyerOffice, bool>> FindNearestLawyerOfficesFilter()
            {
                return x => ();
            }

            return _repository.Find(FindNearestLawyerOfficesFilter());*/

            return null;
        }
    }
}
