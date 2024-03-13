using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;
using SmartH2RCore.Models.DTO.EmployeeDTO;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface.Employee
{
    public interface IJobDetailsService : IBaseService<JobDetails>
    {
        Task<JobDetails> GetJobDetailsByEmployeeIdByEmployeeId(int employeeId);
        Task<JqueryDataTablesPagedResults<JobDetailsDTO>> GetJobDetailes(JqueryDataTablesParameters param, int jobId);
      
    }
}
