﻿using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
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
    }
}
