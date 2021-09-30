using AutoMapper;
using MovieEngine.Database;
using MovieEngine.Infrastructure.Requests;
using MovieEngine.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEngine.Infrastructure.Mappers
{
   public class Mapper:Profile
    {

        public Mapper()
        {
            CreateMap<MovieAndTvShowInsertRequest, MovieAndTvShow>();
            CreateMap<MovieAndTvShow, MovieAndTvShowResponse>().ReverseMap();

            CreateMap<Rating, RatingResponse>().ReverseMap();
            CreateMap<RatingInsertRequest, Rating>();
        }
    }
}
