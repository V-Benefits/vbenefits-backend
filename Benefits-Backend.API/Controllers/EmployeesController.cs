﻿using System;
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
        private readonly IVestingRulesService _vestingRulesService;
        private readonly IAppSettingService _appSettingService;

        public EmployeesController(IMapper mapper, IUnitOfWork unitOfWork, IEmployeeService employeeService,
            IVestingRulesService vestingRulesService, IAppSettingService appSettingService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.employeeService = employeeService;
            _vestingRulesService = vestingRulesService;
            _appSettingService = appSettingService;
        }

        //[HttpPost("add")]
        [HttpPost]
        public async Task<IActionResult> Post(EmployeeForAddDTO model)
        {
            var vesting = _vestingRulesService.GetVestingRules();
            var maxvalue = _appSettingService.GetPensionMaxPercent();

            Employee employee = mapper.Map<Employee>(model);
            employeeService.CreateEmployee(employee);
            EmployeeForViewDTO empResult = mapper.Map<EmployeeForViewDTO>(employee);

            await unitOfWork.Commit();
            empResult.Id= employee.Id;
            return Ok(empResult);
        }
    }
}