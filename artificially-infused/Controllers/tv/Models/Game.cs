using Azure;
using Azure.Data.Tables;

namespace artificially_infused.Controllers.tv
{
    /*
    # API Endpoints

## POST Game
- Return a game id
- This makes the game structure.


## POST Game Player
- caller provides the player name
- returns player id (string)
- API would update game structure to add the player and their word bank


## DELETE Game
- Host decides to not play the game or they don't want to play again.


## DELETE Game Player
- Host can remove a player
- This would delete the player from the array in the game


## POST Game-Start
- Host has enough players and starts the game.
- API will update the game object with the round info (round number 1, template)


## POST Round Solution
- Caller provides game id, player id and the prompt
- Request
```json
{
    "words" [
        "ski",
        "monkey"
    ]
}
```


## POST Round Vote
- endpoint will accept game id, awarded player id
- don't need a response. 204


## POST End Round
Request has gameId
Response: 204
 API will calculate top level score. Reset round number and template and fill word banks


## GET Game by ID
GET `/api/game/{gameId}`

- Ideally we want to get back a solution URL that is directly to the storage account so we don't need to make another API call to get the image from blob.
- solution images will be in storage under a key like: `/{gameId}/{roundNumber}/{playerId}.jpg`.
- API layer would have a very large word bank. Each round, every player will get their own set of 7 words per word type.

Response:
```json
{
    "players": [
        {
            "playerId": 1234,
            "name": "Steve",
            "avatarUrl": "https://api.artificially-infused.com/Image/{gameId}/{playerId}",
            "nouns": [ "Cat", "Dog" ],
            "verbs": [ "run", "carry" ],
            "score": 22
        },
        {
            "playerId": 5678,
            "name": "John",
            "imageUrl": "https://api.artificially-infused.com/Image/{gameId}/{playerId}",
            "nouns": [ "Cat", "Dog" ],
            "verbs": [ "run", "carry" ],
            "score": 11
        }
    ],
    "round": {
        "roundNumber": 1,
        "template": "I would like to {verb} with the {noun}.",
        "solutions": [
            {
                "playerId": 1234,
                "prompt": "I would like to ski with the monkey.",
                "ImageUrl": "https://api.artificially-infused.com/Image/{gameId}/{roundNumber}/{playerId}",
                "votes": 2
            },
            {
                "playerId": 5678,
                "prompt": "I would like to jump with the dog.",
                "ImageUrl": "https://api.artificially-infused.com/Image/{gameId}/{roundNumber}/{playerId}",
                "votes": 1
            }
        ]
    }
}



    */
    public class Game: BaseEntity
    {
        public Game() { 
            Code = "";
            Players = new List<Player>(); 
            Round = new Round();
        }
        
        public string Code { get; set; }
        public List<Player> Players { get; set; }
        public Round Round { get; set; }
    }
}
