using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Threading.Tasks;
namespace SmartH2RCore.Services.Service.Employee
{
    public class ApproverInformationService : BaseService<ApproverInformation>, IApproverInformationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApproverInformationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ApproverInformation> GetApproverInformationByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<ApproverInformation>().FindBy(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();
        }
    }
}
