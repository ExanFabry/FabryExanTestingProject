using Microsoft.AspNetCore.Mvc;
using FabryExanProject.Services;
using FabryExanProject.Models;

namespace FabryExanProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : ControllerBase
    {
        private readonly IHandelingen _handelingenService;

        public FilmController(IHandelingen handelingenService)
        {
            _handelingenService = handelingenService;
        }
        [HttpGet("choosegenre/{genre}")]
        public async Task<ActionResult<Films?>> RandomMovieGenerator(string genre)
        {
            Films? film = await _handelingenService.ReturnFilmWithGenre(genre);
            if (film == null)
            {
                return NotFound();
            }
            return Ok(film);
        }
    }
}
