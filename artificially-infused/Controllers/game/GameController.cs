using artificially_infused.Controllers.tv;
using artificially_infused.Services;
using Microsoft.AspNetCore.Mvc;

namespace artificially_infused.Controllers.game
{
    [ApiController]
    [Route("[controller]")]
    public class GameController
    {
        public GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("{gameId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Game> Get(string gameId)
        {
            var game = _gameService.GetGame(gameId);
            return new OkObjectResult(game);
        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Game> Create()
        {
            var game = _gameService.CreateGame();
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
