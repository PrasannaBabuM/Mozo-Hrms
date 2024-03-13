using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class ProfessionalQualificationService : BaseService<ProfessionalQualification>, IProfessionalQualificationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfessionalQualificationService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProfessionalQualification>> GetProfessionalQualificationDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<ProfessionalQualification>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
