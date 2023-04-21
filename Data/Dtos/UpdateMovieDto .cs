using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesApi.Data.Dtos;

public class UpdateMovieDto
{
    [Required(ErrorMessage = "The Movie Title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "The Movie Title is required")]
    [StringLength(50, ErrorMessage = "The Movie Genre length is too longer")]
    public string Genre { get; set; }

    [Required]
    [Range(70, 600, ErrorMessage = "The Duration must be between 70 and 600 minutes")]
    public int Duration { get; set; }
}