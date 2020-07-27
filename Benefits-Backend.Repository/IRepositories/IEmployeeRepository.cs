using Benefits_Backend.Domain.Entities;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);
        Employee Edit(Employee employee);
        string GetEmployeeEmail(int staffId);
        int GetEmployeeNumberOfUsedLines(int staffId);
        int GetEmployeeIdByStaffId(int staffId);
    }
}
