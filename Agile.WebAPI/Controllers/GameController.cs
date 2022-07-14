using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Agile.WebAPI.Data;
using Agile.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Agile.WebAPI.Data.Entities;

namespace Agile.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private ApplicationDbContext _context;
        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddNewGame([FromForm] GameCreate game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Games.Add(new GameEntity()
            {
                Title = game.Title,
                Description = game.Description,
                GameSystem = game.GameSystem,
                Genre = game.Genre,
                MaturityRating = game.MaturityRating,
                Developer = game.Developer,
                ReleaseDate = game.ReleaseDate
            });
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ShowAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return Ok(games);
        }
    }
}
