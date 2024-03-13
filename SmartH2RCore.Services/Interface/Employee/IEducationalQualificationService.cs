using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface.Employee
{
    public interface IEducationalQualificationService : IBaseService<EducationalQualification>
    {
        Task<List<EducationalQualification>> GetEducationalDetailsByEmployeeId(int employeeId);
    }
}
