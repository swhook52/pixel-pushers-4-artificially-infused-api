using Microsoft.Extensions.Options;

namespace artificially_infused.Controllers.tv
{
    /*"playerId": 5678,
                "prompt": "I would like to jump with the dog.",
                "ImageUrl": "https://api.artificially-infused.com/Image/{gameId}/{roundNumber}/{playerId}",
                "votes": 1
    */

    public class Solution
    {

        public Solution() {
            PlayerId = "";
            Prompt = "";
            ImageUrl = "";
            Votes = 0;
        
        }
        public string PlayerId { get; set; }
        public string Prompt { get; set; }
        public string ImageUrl { get; set; }
        public int Votes { get; set; }
    }
}
