using AutoMapper;
using Microsoft.EntityFrameworkCore;
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
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;

        public UserService(IMapper mapper,MyContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<UserResponse>> get(UserSearchRequest request)
        {
            var query = _context.User.AsQueryable();
            if (request != null)
            {
                if (request.UserID.HasValue)
                {
                    query = query.Where(q => q.UserID == request.UserID);
                }
                if (!string.IsNullOrWhiteSpace(request.FirstName))
                {
                    var normalizedName = request.FirstName.ToLower();
                    query = query.Where(q => q.FirstName.ToLower().Contains(normalizedName));
                }
                if (!string.IsNullOrWhiteSpace(request.LastName))
                {
                    var normalizedName = request.LastName.ToLower();
                    query = query.Where(q => q.LastName.ToLower().Contains(normalizedName));
                }
            }
            var list =await query.ToListAsync();
            return _mapper.Map<List<UserResponse>>(list);
        }
    }
}
