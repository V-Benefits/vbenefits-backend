using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.UnitOFWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Benefits_Backend.Service.IServices;
using Benefits_Backend.API.DTO.MedicalRequest;

namespace Benefits_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalRequestController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMedicalRequestService medicalRequestService;

        public MedicalRequestController(IMapper mapper, IUnitOfWork unitOfWork, IMedicalRequestService medicalRequestService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.medicalRequestService = medicalRequestService;
        }

        [HttpPost("AddMedicalCardRequestForEmployee")]
        public async Task<IActionResult> AddMedicalCardRequestForEmployee([FromBody] EmployeeMedicalRequestForAddDTO employeeMedicalRequestForAddDTO)
        {
            MedicalCardRequestForEmployee medicalCardRequestForEmployee = mapper.Map<MedicalCardRequestForEmployee>(employeeMedicalRequestForAddDTO);
            medicalCardRequestForEmployee.RequestedOn = DateTime.Now;
            medicalCardRequestForEmployee.RequestedById = 1;  /// to be changed later with the actual id

            medicalRequestService.AddMedicalCardRequestForEmployee(medicalCardRequestForEmployee);
            try
            {
               await unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("AddMedicalCardRequestForSpouse")]
        public async Task<IActionResult> AddMedicalCardRequestForSpouse([FromBody] SpouseMedicalRequestForAddDTO spouseMedicalRequestForAddDTO)
        {
            MedicalCardRequestForSpouse medicalCardRequestForSpouse = mapper.Map<MedicalCardRequestForSpouse>(spouseMedicalRequestForAddDTO);
            medicalCardRequestForSpouse.RequestedOn = DateTime.Now;
            medicalCardRequestForSpouse.RequestedById = 1;  /// to be changed later with the actual id
            medicalRequestService.AddMedicalCardRequestForSpouse(medicalCardRequestForSpouse);
            try
            {
               await unitOfWork.Commit();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}