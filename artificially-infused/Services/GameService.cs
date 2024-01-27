using artificially_infused.Controllers.game;

namespace artificially_infused.Services
{
    public class GameService
    {
        private readonly GameRepository _gameRepository;
        public GameService(GameRepository gameRepo)
        {
            _gameRepository = gameRepo;
        }

        public async Task<Game> GetGame(string gameId)
        {
            return await _gameRepository.GetGameAsync(gameId);
       }

        public async Task<Game> CreateGame()
        {
            var game = GameBuilder.NewGame();
            await _gameRepository.SaveGameAsync(game);
            return game;
        }

        public async Task DeleteGame(string gameId)
        {
            await _gameRepository.DeleteGameAsync(gameId);
        }

        public async Task AddPlayerToGame(string gameId, Player player)
        {
            // Get the Game (should probalby throw if it's not there)
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            
            
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

        public async Task DeletePlayerFromGame(string gameId, string playerId)
        {
            // Get the Game (should probalby throw if it's not there)
            var existingGame = await _gameRepository.GetGameAsync(gameId);

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
