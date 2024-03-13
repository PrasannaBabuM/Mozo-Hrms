using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class EducationalQualificationService : BaseService<EducationalQualification>, IEducationalQualificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EducationalQualificationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<EducationalQualification>> GetEducationalDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<EducationalQualification>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
