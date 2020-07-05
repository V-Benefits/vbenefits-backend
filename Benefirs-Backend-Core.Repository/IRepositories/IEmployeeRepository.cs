using Benefits_Backend_Core.Domain.Entities;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<Employee> Add(Employee employee);
        Employee Edit(Employee employee);
        string GetEmployeeEmail(int staffId);
    }
}
