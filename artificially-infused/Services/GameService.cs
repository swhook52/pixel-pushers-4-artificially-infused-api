using artificially_infused.Controllers.tv;

namespace artificially_infused.Services
{
    public class GameService
    {
        private readonly GameRepository _gameRepository;
        public GameService(GameRepository gameRepo)
        {
            _gameRepository = gameRepo;
        }

        public Game GetGame(string gameId)
        {
            // Get the game from storage
            return new Game()
            {
                Code = gameId
            };
        }

        public Game CreateGame()
        {
            return GameBuilder.NewGame();
        }

        public void DeleteGame(string gameId)
        {
            GameBuilder.DeleteGame(gameId);
        }

        public void AddPlayerToGame(string gameId, Player player)
        {
            // Get the Game (should probalby throw if it's not there)
            var existingGame = GameBuilder.GetGame(gameId);
            
            // Add the player
            if (existingGame.Players == null)
            {
                existingGame.Players = new List<Player> { player };
            }
            else if (existingGame.Players.Exists(p => p.Id == player.Id))
            {
                // throw?
            }
            else
            {
                existingGame.Players.Add(player);
            }

            // Update the Storage
        }

        public void DeletePlayerFromGame(string gameId, string playerId)
        {
            // Get the Game (should probalby throw if it's not there)
            var existingGame = GameBuilder.GetGame(gameId);

            // Delete the player
            if (existingGame.Players == null)
            {
                return;
            }

            var existingPlayer = existingGame.Players.SingleOrDefault(p => p.Id == playerId);
            if (existingPlayer == null)
            {
                return;
            }

            existingGame.Players.Remove(existingPlayer);

            // Update the Storage
        }
    }
}
