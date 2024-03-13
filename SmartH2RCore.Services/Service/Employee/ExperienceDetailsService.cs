using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class ExperienceDetailsService : BaseService<ExperienceDetails>, IExperienceDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExperienceDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ExperienceDetails>> GetExperienceDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<ExperienceDetails>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
