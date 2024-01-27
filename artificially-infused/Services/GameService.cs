using artificially_infused.Controllers.game;
using System.Threading.Tasks;

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

        public async Task StartGame(string gameId)
        {
            // Get the game from storage
            var game = await _gameRepository.GetGameAsync(gameId);

            // Create a round
            game.Round = new Round
            {
                RoundNumber = 1,
                Template = getTemplate(),
            };

            // Save to storage
            await _gameRepository.SaveGameAsync(game);
        }

        private string getTemplate()
        {
            // Get a random prompt template from storage.
            // Not sure how we're getting this right now

            return "A {NOUN} riding a unicycle while juggling multiple {NOUN}";
        }

        public async Task<Game> CreateGame()
        {
            // Generate a new game with a code
            var newGame = GameBuilder.NewGame();

            // Save to storage
            await _gameRepository.SaveGameAsync(newGame);

            // Return it back
            return newGame;
        }

        public async Task DeleteGame(string gameId)
        {
            await _gameRepository.DeleteGameAsync(gameId);
        }

        public async Task AddPlayerToGame(string gameId, Player player)
        {
            // Get the game from storage
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }

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
            await _gameRepository.SaveGameAsync(existingGame);
        }

        public async Task DeletePlayerFromGame(string gameId, string playerId)
        {
            // Get the game from storage
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }

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
            await _gameRepository.SaveGameAsync(existingGame);
        }
    }
}
