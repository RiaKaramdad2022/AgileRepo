using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agile.WebAPI.Models
{
    public class GameDetail
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string GameSystem { get; set; }
        public string Genre { get; set; }
        public string MaturityRating { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        
    }
}