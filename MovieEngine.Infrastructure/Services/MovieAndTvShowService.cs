using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieEngine.Database;
using MovieEngine.Infrastructure.Context;
using MovieEngine.Infrastructure.Requests;
using MovieEngine.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Services
{
    public class MovieAndTvShowService : IMovieAndTvShowService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;

        public MovieAndTvShowService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<MovieAndTvShowResponse>> get(MovieAndTvShowSearchRequest reqeuest)
        {
            var query = _context.MovieAndTvShow.AsQueryable();
            if (reqeuest != null)
            {
                if (!string.IsNullOrWhiteSpace(reqeuest.Title))
                {
                    var normalizedTeamName = reqeuest.Title.ToLower();
                    query = query.Where(q => q.Title.ToLower().Contains(normalizedTeamName));
                }
                if (!string.IsNullOrWhiteSpace(reqeuest.Type))
                {
                    var normalizedTeamName = reqeuest.Type.ToLower();
                    query = query.Where(q => q.Type.ToLower().Contains(normalizedTeamName));
                }

                //if (search.FinishDateStartRange.HasValue)
                //{
                //    query = query.Where(q => q.FinishDate >= search.FinishDateStartRange);
                //}
                //if (search.FinishDateEndRange.HasValue)
                //{
                //    query = query.Where(q => q.FinishDate <= search.FinishDateEndRange);
                //}
            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<MovieAndTvShowResponse>>(list);
        }

        public async Task<MovieAndTvShowResponse> getById(int id)
        {
            var entity =await _context.MovieAndTvShow.FirstOrDefaultAsync(x => x.MovieAndTvShowID == id);
            return _mapper.Map<MovieAndTvShowResponse>(entity);

        }

        public async Task<MovieAndTvShow> Insert(MovieAndTvShowInsertRequest request)
        {
            var entity = _mapper.Map<MovieAndTvShow>(request);
            await _context.MovieAndTvShow.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        //public async Task<MovieAndTvShow> Update(int id, MovieAndTvShowUpdateRequest request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
