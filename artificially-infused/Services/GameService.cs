using artificially_infused.Controllers.game;
using System.Threading.Tasks;

namespace artificially_infused.Services
{
    public class GameService
    {
        private readonly GameRepository _gameRepository;
        private readonly PromptsRepository _promptsRepository;

        public GameService(GameRepository gameRepo)
        {
            _gameRepository = gameRepo;
            _promptsRepository = new PromptsRepository();
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

        private string GetRandomPrompt()
        {
            Random rnd = new Random();
            int num = rnd.Next(_promptsRepository.Prompts.Count);
            return _promptsRepository.Prompts[num];
        }

        private string GetRandomPromptWithStyle()
        {
            Random rnd = new Random();
            int num = rnd.Next(_promptsRepository.Prompts.Count);
            return _promptsRepository.Prompts[num] + " in the style of " + GetRandomPrompt();
        }

        private string GetRandomStyle()
        {
            Random rnd = new Random();
            int num = rnd.Next(_promptsRepository.Styles.Count);
            return _promptsRepository.Styles[num];
        }

        private string getTemplate()
        {
            return GetRandomPrompt();
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

        public async Task EndRound(string gameId)
        {
            // Get the game from storage
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }

            if (existingGame.Round == null)
            {
                existingGame.Round = new Round();
            }
            existingGame.Round.RoundNumber++;
            existingGame.Round.Template = getTemplate();
            var winningPlayer = existingGame.Round.Solutions.Aggregate((i1, i2) => i1.Votes > i2.Votes ? i1 : i2);
            
            foreach (Player p in existingGame.Players)
            {
                //p.Nouns = ;
                //p.verbs
                //p.
                if(p.Id == winningPlayer.PlayerId)
                {
                    p.Score++;
                }
            }
            foreach (Solution s in existingGame.Round.Solutions)
            {
                s.Votes = 0;
                s.ImageUrl = "";
                s.Prompt = "";
            }
            // Update the Storage
            await _gameRepository.SaveGameAsync(existingGame);
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

        public async Task AddVote(string gameId, string playerId)
        {
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }
            Solution s = existingGame.Round.Solutions.Where(x => x.PlayerId == playerId).First();
            s.Votes++;
            await _gameRepository.SaveGameAsync(existingGame);


        }

    }
}
