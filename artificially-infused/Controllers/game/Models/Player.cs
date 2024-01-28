namespace artificially_infused.Controllers.game
{
    /*"playerId": 1234,
            "name": "Steve",
            "avatarUrl": "https://api.artificially-infused.com/Image/{gameId}/{playerId}",
            "nouns": [ "Cat", "Dog" ],
            "verbs": [ "run", "carry" ],
            "score": 22
    */
    public class Player
    {
        public Player() {
            Id = "";
            Name = "";
            avatarUrl = "";
            Nouns = new List<string>();
            Verbs = new List<string>();
            Locations = new List<string>();
            Foods = new List<string>();
            Adjectives = new List<string>();
            Score = 0;
        
        }
        public string Id { get; set; }
        public string Name {  get; set; }
        public string avatarUrl { get; set; }
        public List<string> Nouns { get; set; }
        public List<string> Verbs { get; set; }
        public List<string> Locations { get; set; }
        public List<string> Foods { get; set; }
        public List<string> Adjectives { get; set; }
        public int Score { get; set; }

    }
}
