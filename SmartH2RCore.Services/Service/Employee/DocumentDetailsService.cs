using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class DocumentDetailsService : BaseService<DocumentDetails>, IDocumentDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DocumentDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<DocumentDetails>> GetPhotoIdProofByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<DocumentDetails>().FindBy(x => x.EmployeeId == employeeId && x.DocumentCategory == "PhotoIdProof").ToListAsync();
        }

        public async Task<List<DocumentDetails>> GetAddressProofByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<DocumentDetails>().FindBy(x => x.EmployeeId == employeeId && x.DocumentCategory == "AddressProof").ToListAsync();
        }

        public async Task<List<DocumentDetails>> GetOtherDocumentByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<DocumentDetails>().FindBy(x => x.EmployeeId == employeeId && x.DocumentCategory == "OtherDocuments").ToListAsync();
        }


        public async Task<List<DocumentDetails>> GetAllDocumentByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<DocumentDetails>().FindBy(x => x.EmployeeId == employeeId).ToListAsync();
        }
    }
}
