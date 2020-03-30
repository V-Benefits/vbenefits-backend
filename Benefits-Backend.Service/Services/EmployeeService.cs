using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Benefits_Backend.Service.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public Employee CreateEmployee(Employee employee)
        {
            employeeRepository.Add(employee);
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            employeeRepository.Edit(employee);
            return employee;
        }
    }
}
