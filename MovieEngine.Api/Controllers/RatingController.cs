using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieEngine.Database;
using MovieEngine.Infrastructure.Requests;
using MovieEngine.Infrastructure.Response;
using MovieEngine.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEngine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _service;
        private readonly IMapper _mapper;
        public RatingController(IRatingService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<RatingResponse>>> Get([FromQuery] RatingSearchRequest search)
        {
            return Ok(await _service.get(search));
        }
        [HttpPost]
        public async Task<ActionResult<Rating>> Insert(RatingRestUpsertModel request)
        {
            var insertRequest = _mapper.Map<RatingInsertRequest>(request);
            insertRequest.Date = DateTime.Now;
            return Ok(await _service.Insert(insertRequest));
        }

    }
}
