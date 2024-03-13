using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface.Employee
{
    public interface IEmergencyContactDetailsService : IBaseService<EmergencyContactDetails>
    {
        Task<List<EmergencyContactDetails>> GetEmergencyContactDetailsByEmployeeId(int employeeId);

    }
}
