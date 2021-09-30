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
    public class RatingService : IRatingService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;

        public RatingService(IMapper mapper, MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<RatingResponse>> get(RatingSearchRequest request)
        {
            var query = _context.Rating.Include(q=>q.MovieAndTvShow).AsQueryable();
            if (request != null)
            {
                if (!string.IsNullOrWhiteSpace(request.Title))
                {
                    var normalizedTeamName = request.Title.ToLower();
                    query = query.Where(q => q.MovieAndTvShow.Title.ToLower().Contains(normalizedTeamName));
                }
                if (request.MovieAndTvShowID.HasValue)
                {
                    query = query.Where(q => q.MovieAndTvShowId == request.MovieAndTvShowID);
                }
                if (request.RatingValue.HasValue)
                {
                    query = query.Where(q => q.RatingValue == request.RatingValue);
                }

            }
            var list = await query.ToListAsync();
            return _mapper.Map<List<RatingResponse>>(list);
        }

        public async Task<Rating> Insert(RatingInsertRequest request)
        {
            var entity = _mapper.Map<Rating>(request);
            await _context.Rating.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
