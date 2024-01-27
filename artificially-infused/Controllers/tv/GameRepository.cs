using Azure;
using Azure.Data.Tables;
using System.Threading.Tasks;

namespace artificially_infused.Controllers.tv
{
   
    public class GameRepository
    {
        private readonly TableClient _tableClient;
          public GameRepository(string connectionString)
        {
            string tableName = "game";
            var serviceClient = new TableServiceClient(connectionString);
            _tableClient = serviceClient.GetTableClient(tableName);
            _tableClient.CreateIfNotExistsAsync().Wait(); // Ensure the table exists
        }

        public async Task SaveGameAsync(Game game)
        {
            await _tableClient.UpsertEntityAsync(game);
        }

        public async Task<Game> GetGameAsync(string gameId)
        {
            var partitionKey = gameId;
            var rowKey = gameId;

            var gameEntity = await _tableClient.GetEntityAsync<Game>(partitionKey, rowKey);

            return gameEntity;
        }

        public async IAsyncEnumerable<Game> GetAllGamesAsync()
        {
            await foreach (var entity in _tableClient.QueryAsync<Game>())
            {
                yield return new Game
                {
                   
                };
            }
        }
    }

   
    

}