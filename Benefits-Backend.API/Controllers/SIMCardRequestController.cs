using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend.API.DTO.Employee;
using Benefits_Backend.API.DTO.SIMCardRequest;
using Benefits_Backend.Domain.Context;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.UnitOFWork;
using Benefits_Backend.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benefits_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SIMCardRequestController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISIMCardRequestService _simCardRequestService;
        private readonly IRatePlanRulesService _ratePlanRulesService;
        private readonly IEmployeeService _employeeService;

        public SIMCardRequestController(IMapper mapper, 
            IRatePlanRulesService ratePlanRulesService,
            ISIMCardRequestService simCardRequestService,
            IEmployeeService employeeService)
        {
            _mapper = mapper;
            _simCardRequestService = simCardRequestService;
            _ratePlanRulesService = ratePlanRulesService;
            _employeeService = employeeService;
        }

        [HttpGet("EmployeeEligibileRatePlan/{staffId}")]
        public IActionResult Get(int staffId)
        {
            var employeeNumberOfUsedLines = _simCardRequestService.GetEmployeeNumberOfUsedLines(staffId);
            var employeeBand = _simCardRequestService.GetEmployeeBand(staffId);
            var eligibileRatePlan = _ratePlanRulesService.GetEmployeeEligibileRatePlan(employeeBand);
            EmployeeEligibileRatePlanForViewDTO employeeEligibileRatePlanForView = new EmployeeEligibileRatePlanForViewDTO(
                staffId, employeeBand, eligibileRatePlan, employeeNumberOfUsedLines);

            return Ok(employeeEligibileRatePlanForView);
        }

        [HttpGet("RequestFor")]
        public IActionResult Get()
        {
            var requestForLookUps = _simCardRequestService.GetRequestForLookUps();
            return Ok(requestForLookUps);
        }

        [HttpGet("RequestType/{requestForValue}")]
        public IActionResult GetRequestTypes(string requestForValue)
        {
            var requestTypes = _simCardRequestService.GetRequestTypes(requestForValue);
            return Ok(requestTypes);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SimCardRequestForAddDto model)
        {
            var employeeId = _employeeService.GetEmployeeIdByStaffId(model.StaffId);

            SIMCardRequest simCardRequest = _mapper.Map<SIMCardRequest>(model);
            simCardRequest.RequestedById = employeeId;

            await  _simCardRequestService.CreateSimCardRequest(simCardRequest);
            return Ok();
        }

        [HttpGet("RatePlans/{band}")]
        public IActionResult GetRatePlans(string band)
        {
           var ratePlans=  _simCardRequestService.GetRatePlansForBand(band);
            return Ok(ratePlans);
        }
    }
}