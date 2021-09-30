using MovieEngine.Database;
using MovieEngine.Infrastructure.Requests;
using MovieEngine.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Services
{
  public interface IMovieAndTvShowService
    {
        public Task<List<MovieAndTvShowResponse>> get(MovieAndTvShowSearchRequest reqeuest);

        public Task<MovieAndTvShowResponse> getById(int id);

        public Task<MovieAndTvShow> Insert(MovieAndTvShowInsertRequest request);

        //public Task<MovieAndTvShow> Update(int id, MovieAndTvShowUpdateRequest request);
    }
}
