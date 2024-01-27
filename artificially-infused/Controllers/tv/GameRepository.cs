using Azure;
using Azure.Data.Tables;
using System.Threading.Tasks;

namespace artificially_infused.Controllers.tv
{
   
    public class GameRepository
    {
        private readonly TableClient _tableClient;

        public GameRepository(string connectionString, string tableName)
        {
            var serviceClient = new TableServiceClient(connectionString);
            _tableClient = serviceClient.GetTableClient(tableName);
            _tableClient.CreateIfNotExistsAsync().Wait(); // Ensure the table exists
        }

        public async Task SaveGameAsync(Game game)
        {
            var gameEntity = new GameEntity(game);

            await _tableClient.UpsertEntityAsync(gameEntity);
        }

        public async IAsyncEnumerable<Game> GetAllGamesAsync()
        {
            await foreach (var entity in _tableClient.QueryAsync<GameEntity>())
            {
                yield return new Game
                {
                   
                };
            }
        }
    }

    public class GameEntity : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }

        public string Title { get; set; }
        public int Score { get; set; }

        public GameEntity()
        {
        }

        public GameEntity(Game game)
        {
            PartitionKey = "Games";
            //RowKey = game.Id.ToString();
            //Title = game.Title;
            //Score = game.Score;
        }
    }

}