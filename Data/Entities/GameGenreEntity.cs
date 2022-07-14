using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agile.WebAPI.Data.Entities;

namespace Data.Entities
{
    public class GameGenreEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}