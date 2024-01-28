using shortid.Configuration;
using shortid;

namespace artificially_infused.Controllers.game
{
    public static class GameBuilder
    {
        public static Game NewGame()
        {
            var options = new GenerationOptions(length: 8, useSpecialCharacters: false, useNumbers: true);
            string id = ShortId.Generate(options).ToUpper();
            
            Game game = new Game() { Code = id, RowKey = id, PartitionKey = id };
            return ResetGame(game);
        }
        public static Game ResetGame(Game existingGame)
        {
            existingGame.Round = new Round();
            return existingGame;
        }
        public static Game InitializeRound(Game existingGame)
        {
            existingGame.Round = new Round();
            existingGame.Round.RoundNumber = 1;
            foreach (Player p in existingGame.Players)
            {
                existingGame.Round.Solutions.Add(new Solution() { PlayerId = p.Id, Votes = 0 });
            }
            return existingGame;
        }
    }
}
