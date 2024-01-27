using artificially_infused.Controllers.tv;
using Microsoft.AspNetCore.Mvc;

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
    }
}
