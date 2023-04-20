using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models;

public class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
}