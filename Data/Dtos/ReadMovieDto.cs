using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Data.Dtos;

public class ReadMovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Duration { get; set; }
    public DateTime QueryTime { get; set; } = DateTime.Now;
}