using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agile.WebAPI.Models
{
    public class GameDetail
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string GameSystem { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string MaturityRating { get; set; } = null!;
        public string Developer { get; set; } = null!;
        public DateTime ReleaseDate { get; set; }
        
    }
}