using artificially_infused.Controllers.tv;
using artificially_infused.Services;
using Microsoft.AspNetCore.Mvc;

namespace artificially_infused.Controllers
{
    [ApiController]
    public class GamePlayerController
    {
        public GameService _gameService;

        public GamePlayerController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("game/{gameId}/player")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Create(string gameId, [FromBody] Player player)
        {
            _gameService.AddPlayerToGame(gameId, player);
            return new NoContentResult();
        }

        [HttpDelete("game/{gameId}/player/{playerId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete(string gameId, string playerId)
        {
            _gameService.DeletePlayerFromGame(gameId, playerId);
            return new NoContentResult();
        }
    }
}
