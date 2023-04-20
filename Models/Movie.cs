using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models;

public class Movie
{
    [Required(ErrorMessage = "The Movie Title is required")]
    public string Title { get; set; }
    [Required(ErrorMessage = "The Movie Title is required")]
    [MaxLength(50, ErrorMessage = "The Movie Genre length is too longer")]
    public string Genre { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "The Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}