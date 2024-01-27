using shortid.Configuration;
using shortid;

namespace artificially_infused.Controllers.tv
{
    public static class GameBuilder
    {
        public static Game NewGame()
        {
            var options = new GenerationOptions(length: 8, useSpecialCharacters: false, useNumbers: true);
            string id = ShortId.Generate(options);
            
            Game game = new Game() { Code = id.Insert(4, " ") };
            return ResetGame(game);
        }
        public static Game ResetGame(Game existingGame)
        {

            return existingGame;
        }

        public static void DeleteGame(string gameId)
        {
            // Delete from storage
        }
    }
}
