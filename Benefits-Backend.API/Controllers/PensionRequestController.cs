using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        public PensionRequestController(IMapper mapper, IUnitOfWork unitOfWork, IPensionRequestService pensionRequestService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.pensionRequestService = pensionRequestService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PensionRequestForAddDto model)
        {
            PensionRequest pensionRequest  = mapper.Map<PensionRequest>(model);
            pensionRequestService.CreatePensionRequest(pensionRequest);
            await unitOfWork.Commit();
            return Ok();
        }
    }
}