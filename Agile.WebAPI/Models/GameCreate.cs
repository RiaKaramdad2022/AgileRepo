using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Agile.WebAPI.Models
{
    public class GameCreate
    {
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = null!;
        [Required]
        public string GameSystem { get; set; } = null!;
        [Required]
        public string Genre { get; set; } = null!;
        [Required]
        public string MaturityRating { get; set; } = null!;
        [Required]
        public string Developer { get; set; } = null!;
        [Required]
        public DateTime ReleaseDate { get; set; }
    }
}