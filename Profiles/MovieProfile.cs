using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MoviesApi.Data.Dtos;
using MoviesApi.Models;

namespace MoviesApi.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
    }
}