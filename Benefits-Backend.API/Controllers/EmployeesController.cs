using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend.API.DTO.Employee;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.UnitOFWork;
using Benefits_Backend.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benefits_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IEmployeeService employeeService;

        public EmployeesController(IMapper mapper, IUnitOfWork unitOfWork, IEmployeeService employeeService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.employeeService = employeeService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeForAddDTO model)
        {
            Employee employee = mapper.Map<Employee>(model);
            employeeService.CreateEmployee(employee);
            await unitOfWork.Commit();
            return Ok();
        }
    }
}