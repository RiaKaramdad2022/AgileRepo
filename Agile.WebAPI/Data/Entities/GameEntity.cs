using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Agile.WebAPI.Data.Entities
{
    public class GameEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
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