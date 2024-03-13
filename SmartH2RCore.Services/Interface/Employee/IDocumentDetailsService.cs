using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface.Employee
{
    public interface IDocumentDetailsService : IBaseService<DocumentDetails>
    {
        Task<List<DocumentDetails>> GetAllDocumentByEmployeeId(int employeeId);
        Task<List<DocumentDetails>> GetPhotoIdProofByEmployeeId(int employeeId);
        Task<List<DocumentDetails>> GetAddressProofByEmployeeId(int employeeId);
        Task<List<DocumentDetails>> GetOtherDocumentByEmployeeId(int employeeId);
    }
}
