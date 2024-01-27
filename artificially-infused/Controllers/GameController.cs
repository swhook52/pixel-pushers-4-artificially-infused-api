﻿using artificially_infused.Controllers.game;
using artificially_infused.Services;
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

        [HttpPost("{gameId}/start")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Start(string gameId)
        {
            // Host has enough players and starts the game.
            // Update the game with the round info(round number 1, template)

            await _gameService.StartGame(gameId);
            return new NoContentResult();
        }

        [HttpDelete("{gameId}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(string gameId)
        {
            await _gameService.DeleteGame(gameId);
            return new NoContentResult();
        }
    }
}