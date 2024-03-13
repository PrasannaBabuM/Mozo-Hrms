using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class EmergencyContactDetailsService : BaseService<EmergencyContactDetails>, IEmergencyContactDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmergencyContactDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<EmergencyContactDetails>> GetEmergencyContactDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<EmergencyContactDetails>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
