using shortid.Configuration;
using shortid;

namespace artificially_infused.Controllers.game
{
    public static class GameBuilder
    {
        public static Game NewGame()
        {
            var options = new GenerationOptions(length: 8, useSpecialCharacters: false, useNumbers: true);
            string id = ShortId.Generate(options);
            
            Game game = new Game() { Code = id };
            return ResetGame(game);
        }
        public static Game ResetGame(Game existingGame)
        {
            existingGame.Round = new Round();
            return existingGame;
        }

        
    }
}
