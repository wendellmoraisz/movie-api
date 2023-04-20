using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesApi.Models;

namespace MoviesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MovieController : ControllerBase
{

    private static List<Movie> movies = new List<Movie>();
    private static int id = 0;

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        movie.Id = id++;
        movies.Add(movie);
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovies() => movies;

    [HttpGet("{id}")]
    public Movie? GetMovieById(int id)
    {
        return movies.FirstOrDefault(movie => movie.Id == id);
    }

}