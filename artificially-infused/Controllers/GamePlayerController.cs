using artificially_infused.Controllers.game;
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
        public async Task<IActionResult> Create(string gameId, [FromBody] Player player)
        {
            await _gameService.AddPlayerToGame(gameId, player);
            return new NoContentResult();
        }

        /*
       ## POST Round Vote
       - endpoint will accept game id, awarded player id
       - don't need a response. 204
       */
        [HttpPost("game/{gameId}/player/{playerId}/vote")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Vote(string gameId, string playerId)
        {
            await _gameService.AddVote(gameId, playerId);
            return new NoContentResult();
        }

        [HttpDelete("game/{gameId}/player/{playerId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(string gameId, string playerId)
        {
            await _gameService.DeletePlayerFromGame(gameId, playerId);
            return new NoContentResult();
        }

        /*
        ## POST Round Solution
        - Caller provides game id, player id and the prompt
        - Request
        ```json
        {
        "words" [
        "ski",
        "monkey"
        ]

        */
        [HttpPost("game/{gameId}/player/{playerId}/solution")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Solution(string gameId, string playerId, [FromBody] List<string> words)
        {
            await _gameService.PlayerSubmitWords(gameId, playerId, words);
            return new NoContentResult();
        }
    }
}
