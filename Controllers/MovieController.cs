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

    [HttpPost]
    public void AddMovie([FromBody] Movie movie)
    {
        movies.Add(movie);
    }

    [HttpGet]
    public IEnumerable<Movie> GetMovies() => movies;

}