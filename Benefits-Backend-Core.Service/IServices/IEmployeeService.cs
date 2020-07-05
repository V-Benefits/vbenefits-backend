using Benefits_Backend_Core.Domain.Entities;

namespace Benefits_Backend_Core.Service.IServices
{
    public interface IEmployeeService
    {
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
    }
}
