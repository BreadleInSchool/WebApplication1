using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GameController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<GameDTO>>> GetAllUser ()
        {
            try


                var users = await _context.Games.Select(u => new GameDTO
                {
                    Artworks = u.Artworks,
                    GameType = u.GameType,
                    Title = u.Title,
                    Slug = u.Slug,
                    Platforms = u.Platforms,
                    Genre = u.Genres,
                    Developer = u.Developer,
                    ReleaseYear = u.ReleaseYear,

                }).ToListAsync();
            }
            catch (Exception ex)
            {
                var response = new
                {
                    Success = true,
                    Message = "An error occured while retrieving data.",
                    Errors = new List<string> { ex.Message }
                };
                return StatusCode(500, response);
            }
        }

    }
}
