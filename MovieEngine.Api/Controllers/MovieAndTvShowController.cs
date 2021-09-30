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
    public class MovieAndTvShowController : ControllerBase
    {
        private readonly IMovieAndTvShowService _service;
        private readonly IMapper _mapper;
        public MovieAndTvShowController(IMovieAndTvShowService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<MovieAndTvShowResponse>>> Get([FromQuery] MovieAndTvShowSearchRequest search)
        {
            return Ok(await _service.get(search));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieAndTvShowResponse>> GetById(int id)
        {
            return Ok(await _service.getById(id));
        }
        [HttpPost]
        public async Task<ActionResult<MovieAndTvShow>> Insert(MovieAndTvShowInsertRequest request)
        {
            return Ok(await _service.Insert(request));
        }

         
    }
}
