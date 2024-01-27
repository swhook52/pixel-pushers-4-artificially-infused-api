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
        /*
     
        ## GET Game by ID

        */

        // GET api/<TVController>/5
        [HttpGet("{code}")]
        public string Get(string code)
        {
            return GameBuilder.NewGame().Code = code;
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
