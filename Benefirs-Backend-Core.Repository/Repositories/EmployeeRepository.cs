using Benefits_Backend_Core.Domain.Context;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.Repository.Repositories
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
          return context.Employees.Where(e => e.StaffId == staffId.ToString()).FirstOrDefault().Email;
        }
    }
}
