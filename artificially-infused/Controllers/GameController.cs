using artificially_infused.Controllers.game;
using artificially_infused.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace artificially_infused.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController: ControllerBase
    {
        public GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("{gameId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Game>> Get(string gameId)
        {
            
            
            try
            {
                var game =  await _gameService.GetGame(gameId);

                if (game != null)
                {
                    return new OkObjectResult(game);
                }
                else
                {
                    return NotFound(); // or return a more specific NotFound result if needed
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server Error: {ex.Message}");
                // Log the exception for debugging purposes
            }

        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Game>> Create()
        {
            var game = await _gameService.CreateGame();

            return new CreatedAtActionResult("Get", "Game", new { gameId = game.Code }, game);
        }

        [HttpDelete("{gameId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(string gameId)
        {
            _gameService.DeleteGame(gameId);
            return new NoContentResult();
        }
    }
}
