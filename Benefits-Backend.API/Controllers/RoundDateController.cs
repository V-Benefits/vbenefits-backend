using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Benefits_Backend.API.DTO.RoundDate;
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
    public class RoundDateController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly ApplicationContext _context;
        private readonly IRoundDatesService _roundDatesService;


        public RoundDateController(IMapper mapper,
            IUnitOfWork unitOfWork,
            ApplicationContext context,
            IRoundDatesService roundDatesService)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            _context = context;
            _roundDatesService = roundDatesService;
        }

       // [ProducesResponseType(typeof(IEnumerable<RoundDate>), (int)HttpStatusCode.OK)]
        [HttpGet]
        public List<RoundDateForViewDto> Get()
        {
            var rounds = _context.RoundDates.Where(x => x.IsActive == true).ToList();
            List<RoundDateForViewDto> roundViews = mapper.Map<List<RoundDateForViewDto>>(rounds);
            return roundViews;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RoundDateForAddDto model)
        {
            var activeRound = _roundDatesService.GetActiveRound();
            if (activeRound != null)

              activeRound.IsActive = false;

            RoundDate round = mapper.Map<RoundDate>(model);
            await _roundDatesService.AddRound(round);
     
            return Ok();
        }

    }
}