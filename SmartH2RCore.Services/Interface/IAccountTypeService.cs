using JqueryDataTables.ServerSide.AspNetCoreWeb.Models;

using SmartH2RCore.Models.Common;
using SmartH2RCore.Models.DTO.Master;
using SmartH2RCore.Services.Base;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface
{
    public interface IAccountTypeService : IBaseService<AccountType>
    {
        Task<JqueryDataTablesPagedResults<AccountTypeDTO>> GetAccountType(JqueryDataTablesParameters table);
    }
}
