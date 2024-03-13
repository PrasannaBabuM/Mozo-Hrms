using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

namespace SmartH2RCore.Services.Service
{
    public class BranchCityServices : BaseService<BranchCity>, IBranchCityServices
    {
        public BranchCityServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
