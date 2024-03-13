using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Base;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface
{
    public interface IEmployeeStatusService : IBaseService<EmployeeStatus>
    {

        Task<JqueryDataTablesPagedResults<EmployeeStatusDTO>> GetEmployeeStatus(JqueryDataTablesParameters table);
    }
}
