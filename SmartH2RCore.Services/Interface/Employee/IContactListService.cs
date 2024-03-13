using SmartH2RCore.Models.Employee;
using SmartH2RCore.Services.Base;

using System.Threading.Tasks;

namespace SmartH2RCore.Services.Interface.Employee
{
    public interface IContactListService : IBaseService<ContactList>
    {
        Task<ContactList> GetContactListByEmployeeId(int employeeId);


    }
}
