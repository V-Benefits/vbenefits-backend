using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend.Repository.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationContext context;

        public EmployeeRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public async Task<Employee> Add(Employee employee)
        {
            await context.Employees.AddAsync(employee);
            return employee;
        }
        public Employee Edit(Employee employee)
        {
            context.Entry(employee).State = EntityState.Modified;
            return employee;
        }
        public string GetEmployeeEmail(int staffId)
        {
            //   return context.Employees.Where(e => e.StaffId == staffId.ToString()).FirstOrDefault().Email;
            return "";
        }

        public int GetEmployeeNumberOfUsedLines(int staffId)
        {
            var employee = this.context.Employees.Where(e => e.StaffId == staffId).FirstOrDefault();
            //checked if employee equal null
            return employee.NumberOfUsedLines;
        }

        public int GetEmployeeIdByStaffId(int staffId)
        {
            var employeeId =this.context.Employees.Where(e => e.StaffId == staffId).FirstOrDefault().Id;
            return employeeId;
        }
    }
}
