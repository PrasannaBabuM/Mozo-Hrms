using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Common;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface;

namespace SmartH2RCore.Services.Service
{
    public class BranchDepartmentServices : BaseService<BranchDepartment>, IBranchDepartmentServices
    {
        public BranchDepartmentServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
