﻿using artificially_infused.Controllers.game;
using artificially_infused.Controllers.game.Models;
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
            await _gameService.AddPlayerToGame(gameId.ToUpper(), player);
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

        [HttpPost("game/{gameId}/player/{playerId}/solution")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Solution(string gameId, string playerId, [FromBody] SolveRequest solveRequest)
        {
            await _gameService.AddSolution(gameId, playerId, solveRequest);
            return new NoContentResult();
        }
    }
}
