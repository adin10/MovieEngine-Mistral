using MovieEngine.Infrastructure.Requests;
using MovieEngine.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Services
{
   public interface IUserService
    {
        public Task<List<UserResponse>> get(UserSearchRequest request);
    }
}
