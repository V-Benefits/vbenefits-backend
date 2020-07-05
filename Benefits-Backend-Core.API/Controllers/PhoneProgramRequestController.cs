using AutoMapper;
using Benefits_Backend_Core.API.DTO.PhoneProgramRequest;
using Benefits_Backend_Core.Domain.Entities;
using Benefits_Backend_Core.Repository.UnitOFWork;
using Benefits_Backend_Core.Service.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Benefits_Backend_Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneProgramRequestController :  ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IPhoneProgramRequestService phoneProgramRequestService;

        public PhoneProgramRequestController(IMapper mapper, IUnitOfWork unitOfWork, IPhoneProgramRequestService phoneProgramRequestService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.phoneProgramRequestService = phoneProgramRequestService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(PhoneProgramRequestForAddDto model)
        {
            PhoneProgramRequest phoneProgramRequest = mapper.Map<PhoneProgramRequest>(model);
            phoneProgramRequestService.CreatePhoneProgramRequest(phoneProgramRequest);
            await unitOfWork.Commit();
            return Ok();
        }
    }
}
