using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agile.WebAPI.Models
{
    public class GameListItem
    {
         public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string GameSystem { get; set; } = null!;
    }
}