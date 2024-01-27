namespace artificially_infused.Controllers.tv
{
    /*"roundNumber": 1,
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
    */
    public class Round
    {
        public Round() {
            Solutions = new List<Solution>();
            Template = "";
            RoundNumber = 0;
        }
        public int RoundNumber { get; set; }
        public string Template { get; set; }
        public List<Solution> Solutions { get; set; }
       
    }
}
