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
        public void AddMedicalCardRequestForEmployee([FromBody] EmployeeMedicalRequestForAddDTO employeeMedicalRequestForAddDTO)
        {
            // map from dto to entity
            // set request date to now 
            // set active to false
            // set the employee Id (get it first)
            // send the mapped one
            
            medicalRequestService.AddMedicalCardRequestForEmployee();
        }

        [HttpPost("AddMedicalCardRequestForSpouse")]
        public void AddMedicalCardRequestForSpouse([FromBody] SpouseMedicalRequestForAddDTO spouseMedicalRequestForAddDTO)
        {
            // map from dto to entity
            // send the mapped one
            medicalRequestService.AddMedicalCardRequestForSpouse();
        }
    }
}