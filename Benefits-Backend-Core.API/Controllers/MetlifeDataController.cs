﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend_Core.API.DTO.MetlifeData;
using Benefits_Backend_Core.API.DTO.PensionRequest;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.UnitOFWork;
using Benefits_Backend_Core.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Benefits_Backend_Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetlifeDataController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMetlifeDataService metlifeDataService;

        public MetlifeDataController(IMapper mapper, IUnitOfWork unitOfWork, IMetlifeDataService metlifeDataService)
        {

            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.metlifeDataService = metlifeDataService;
        }


        [HttpPost]
        public IActionResult Post(List<MetlifeDataForAddDto> model)
        {
            List<MetlifeData> errorList = new List<MetlifeData>();
            foreach (var metlifeDataRecord in model)
            {
                MetlifeData metlifeData = mapper.Map<MetlifeData>(metlifeDataRecord);

                if (!metlifeDataService.AddMetlifeDataRecord(metlifeData))
                {
                    errorList.Add(metlifeData);
                }
            }

            //await unitOfWork.Commit();
            return Ok();
        }
    }
}