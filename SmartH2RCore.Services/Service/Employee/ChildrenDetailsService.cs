using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;
namespace SmartH2RCore.Services.Service.Employee
{
    public class ChildrenDetailsService : BaseService<ChildrenDetails>, IChildrenDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChildrenDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ChildrenDetails>> GetChilderDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<ChildrenDetails>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
