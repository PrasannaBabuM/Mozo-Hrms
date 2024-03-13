using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

namespace SmartH2RCore.Services.Service
{
    public class BranchEmployeeSubTypeServices : BaseService<BranchEmployeeSubType>, IBranchyEmployeeSubTypeServices
    {
        public BranchEmployeeSubTypeServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
