using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class PersonalDetailsService : BaseService<PersonalDetails>, IPersonalDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonalDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PersonalDetails> GetPersonalDetailsByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<PersonalDetails>().FindBy(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();
        }
    }
}
