using Microsoft.AspNetCore.Mvc;
using shortid;
using shortid.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace artificially_infused.Controllers.tv
{
    [ApiController]
    [Route("[controller]")]
    public class TVController : ControllerBase
    {
        private readonly string startificiallyinfuseddev = "DefaultEndpointsProtocol=https;AccountName=startificiallyinfuseddev;AccountKey=QShFG5XUWa5f6OwqJ/UzxtnIORBsWZxylC1vP9xa4hskWJ++EYDRGNTgqGFhIC3GUtHRqOBY0c0K+AStqZOQag==;EndpointSuffix=core.windows.net";

        private readonly GameRepository _gameRepository;
        public TVController()
        {
            _gameRepository = new GameRepository(startificiallyinfuseddev);
        }
        /*
     
        ## GET Game by ID

        */

        // GET api/<TVController>/5
        [HttpGet("{code}")]
        public async Task<ActionResult<Game>> Get(string code)
        {
            
            try
            {
                var game = await _gameRepository.GetGameAsync(code);

                if (game != null)
                {
                    return Ok(game);
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

        // POST <TVController>
        //* ## POST Game
        //- Return a game id
        //- This makes the game structure.
        [HttpPost]
        public void Post([FromBody] Player player)
        {
        }

        /*## POST Game Player
        - caller provides the player name
        - returns player id (string)
        - API would update game structure to add the player and their word bank
        */

        /*## DELETE Game
        - Host decides to not play the game or they don't want to play again.
        */

        /*
        ## DELETE Game Player
        - Host can remove a player
        - This would delete the player from the array in the game
        */

        /*
        ## POST Game-Start
        - Host has enough players and starts the game.
        - API will update the game object with the round info (round number 1, template)
        */

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

        /*
        ## POST Round Vote
        - endpoint will accept game id, awarded player id
        - don't need a response. 204
        */
        
        /*
        ## POST End Round
                Request has gameId
        Response: 204
        API will calculate top level score. Reset round number and template and fill word banks
        */
    }
}
