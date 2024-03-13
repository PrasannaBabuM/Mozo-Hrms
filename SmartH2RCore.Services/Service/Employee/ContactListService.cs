using Microsoft.EntityFrameworkCore;

using SmartH2RCore.Core.Uow;
using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;
using SmartH2RCore.Services.Interface.Employee;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Service.Employee
{
    public class ContactListService : BaseService<ContactList>, IContactListService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContactListService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ContactList> GetContactListByEmployeeId(int employeeId)
        {
            return await _unitOfWork.GetRepository<ContactList>().FindBy(x => x.EmployeeId == employeeId).FirstOrDefaultAsync();
        }
    }
}
