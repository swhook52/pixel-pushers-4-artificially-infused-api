using Azure;
using Azure.Data.Tables;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace artificially_infused.Controllers.game 
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
            await _tableClient.UpsertEntityAsync(new GameEntity(game));
        }

        public async Task<Game> GetGameAsync(string gameId)
        {
            var partitionKey = gameId;
            var rowKey = gameId;

            GameEntity gameEntity = await _tableClient.GetEntityAsync<GameEntity>(partitionKey, rowKey);
            var game = new Game();
            game.Code = gameEntity.Code;
            game.PartitionKey = gameEntity.PartitionKey;
            game.RowKey = gameEntity.RowKey;
            game.ETag = gameEntity.ETag;
            game.Timestamp = gameEntity.Timestamp;
            game.Players = JsonConvert.DeserializeObject<List<Player>>(gameEntity.Players);
            game.Round = JsonConvert.DeserializeObject<Round>(gameEntity.Round);
            return game;
        }
        public async Task DeleteGameAsync(string gameId)
        {
            var partitionKey = gameId;
            var rowKey = gameId.ToString();

            var gameEntity = new Game { PartitionKey = partitionKey, RowKey = rowKey };

            await _tableClient.DeleteEntityAsync(gameEntity.PartitionKey, gameEntity.RowKey, gameEntity.ETag);
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
    public class GameEntity : ITableEntity
    {
        public string Players { get; set; }
        public string Round { get; set; }
        public string Code { get; set; }
        public GameEntity()
        {
        }

        public GameEntity(Game game)
        {
            PartitionKey = game.PartitionKey;
            RowKey = game.RowKey;
            Players = JsonConvert.SerializeObject(game.Players);
            Round = JsonConvert.SerializeObject(game.Round);
            Code = game.Code;
        }

        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }



}