using Lawyer.DomainEntities;
using System.Collections.Generic;

namespace Lawyer.Service.LawyerOfficeService
{
    public interface ILawyerOfficeService : IBaseService<LawyerOffice>
    {
        IEnumerable<LawyerOffice> GetNearestLawyerOffices(double latitude, double longtitude);
    }
}
