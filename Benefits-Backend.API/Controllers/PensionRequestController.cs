﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using AutoMapper;
using Benefits_Backend.API.DTO.PensionRequest;
using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Repository.UnitOFWork;
using Benefits_Backend.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benefits_Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PensionRequestController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IPensionRequestService pensionRequestService;

        public List<SuccessFactor> successFact = new List<SuccessFactor>();

        public PensionRequestController(IMapper mapper, IUnitOfWork unitOfWork, IPensionRequestService pensionRequestService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.pensionRequestService = pensionRequestService;
            #region success factor
            successFact.Add(
                new SuccessFactor
                {
                    StaffId = 1,
                    Name = "Ahmed",
                    Band = "G",
                    CostCenter = "EG0200G078",
                    Tenure = 1.7,
                    SubBand = "G2",
                    HiringDate = new DateTime(2020, 06, 18)
                });

            successFact.Add(
            new SuccessFactor
            {
                StaffId = 2,
                Name = "Mona",
                Band = "F",
                CostCenter = "EG0200G137",
                Tenure = 19.8,
                SubBand = "F1",
                HiringDate = new DateTime(2020, 06, 04)
            });

            successFact.Add(
                new SuccessFactor
                {
                    StaffId = 3,
                    Name = "Kareem",
                    Band = "G",
                    CostCenter = "EG0200G087",
                    Tenure = 4.5,
                    SubBand = "G2",
                    HiringDate = new DateTime(2015, 09, 15)
                });

            successFact.Add(
                new SuccessFactor
                {
                    StaffId = 4,
                    Name = "Ziad",
                    Band = "F",
                    CostCenter = "EG0200G087",
                    Tenure = 3,
                    SubBand = "F2",
                    HiringDate = new DateTime(2015, 09, 15)
                });
            successFact.Add(
                new SuccessFactor
                {
                    StaffId = 26018,
                    Name = "Mohamed AlMokadem",
                    Band = "G",
                    CostCenter = "EG0200G087",
                    Tenure = 4.5,
                    SubBand = "G2",
                    HiringDate = new DateTime(2018, 03, 20)
                });
            #endregion
        }

        [HttpPost]
        public async Task<IActionResult> Post(PensionRequestForAddDto model)
        {
            PensionRequest pensionRequest = mapper.Map<PensionRequest>(model);
            pensionRequestService.CreatePensionRequest(pensionRequest);
            await unitOfWork.Commit();
            return Ok();
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int staffId)
        {

            var successFactorObject = successFact.Where(sf => sf.StaffId == staffId).FirstOrDefault();
            var pensionRequest = pensionRequestService.CalculatePensionFormula(staffId, successFactorObject);

            return Ok(pensionRequest);
        }

        [HttpGet("GetAllPensionRequests")]
        public IActionResult GetAllPensionRequests()
        {
            var pensionRequestList = pensionRequestService.GetAllRequests();
            List<PensionRequestDTO> pensionRequestDTOs = new List<PensionRequestDTO>();
            foreach(var request in pensionRequestList)
            {
                pensionRequestDTOs.Add(mapper.Map<PensionRequestDTO>(request));

            }
            return Ok(pensionRequestDTOs);
        }

        [HttpGet("RejectPensionRequest")]
        public IActionResult RejectPensionRequest(int staffId)
        {
            pensionRequestService.RejectRequest(staffId);
            unitOfWork.Commit();
            return Ok();
        }


        //[HttpGet("GetApprovedPensionRequests")]
        //public IActionResult GetApprovedPensionRequests()
        //{
        //    return Ok(pensionRequestService.GetApprovedRequests());
        //}

        //[HttpGet("GetCanceledPensionRequests")]
        //public IActionResult GetCanceledPensionRequests()
        //{
        //    return Ok(pensionRequestService.GetCanceledRequests());
        //}

    }
}