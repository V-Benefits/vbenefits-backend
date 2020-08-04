using Benefits_Backend.Domain.Entities;

namespace Benefits_Backend.Service.IServices
{
    public interface IEmployeeService
    {
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        int GetEmployeeIdByStaffId(int staffId);
        Employee GetEmployeeByStaffId(int staffId);
    }
}
