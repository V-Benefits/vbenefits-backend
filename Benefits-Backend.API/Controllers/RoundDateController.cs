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

        public RoundDateController(IMapper mapper, IUnitOfWork unitOfWork, ApplicationContext context)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            _context = context;
        }

       // [ProducesResponseType(typeof(IEnumerable<RoundDate>), (int)HttpStatusCode.OK)]
        [HttpGet]
        public List<RoundDateForViewDto> Get()
        {
            var rounds = _context.RoundDates.Where(x=> x.Year == DateTime.Now.Year).ToList();
            List< RoundDateForViewDto> roundViews = mapper.Map<List<RoundDateForViewDto>>(rounds);
            return roundViews;
        }

    }
}