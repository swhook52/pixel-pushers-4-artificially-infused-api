﻿using artificially_infused.Controllers.game;
using artificially_infused.Controllers.game.Models;
using Azure;
using Azure.Storage.Blobs;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace artificially_infused.Services
{
    public class GameService
    {
        private readonly GameRepository _gameRepository;
        private readonly ImageRepository _imageRepository;
        private readonly PromptsRepository _promptsRepository;
        private readonly HttpClient _httpClient;
        private readonly Random _random = new Random();

        public GameService(GameRepository gameRepo, IHttpClientFactory httpClientFactory, ImageRepository imageRepository)
        {
            _gameRepository = gameRepo;
            _imageRepository = imageRepository;
            _promptsRepository = new PromptsRepository();
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<Game> GetGame(string gameId)
        {
            return await _gameRepository.GetGameAsync(gameId);
        }

        private void FillPlayerCardBanks(Player p)
        {
            int bankSize = 10;
            for (int I = p.Nouns.Count;I< bankSize; I++)
            {
                p.Nouns.Add(GetRandomNoun());
            }
            for (int I = p.Adjectives.Count; I < bankSize; I++)
            {
                p.Adjectives.Add(GetRandomAdjective());
            }
            for (int I = p.Foods.Count; I < bankSize; I++)
            {
                p.Foods.Add(GetRandomFood());
            }
            for (int I = p.Locations.Count; I < bankSize; I++)
            {
                p.Locations.Add(GetRandomLocation());
            }
            for (int I = p.Verbs.Count; I < bankSize; I++)
            {
                p.Verbs.Add(GetRandomVerb());
            }
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
            foreach(var p in game.Players)
            {
                p.Nouns = new List<string>();
                p.Adjectives = new List<string>();
                p.Nouns = new List<string>();
                p.Locations = new List<string>();
                p.Verbs = new List<string>();
                FillPlayerCardBanks(p);
            }

            // Save to storage
            await _gameRepository.SaveGameAsync(game);
        }

        public string GetRandomPrompt()
        {
            int num = _random.Next(1, _promptsRepository.Prompts.Count);
            return _promptsRepository.Prompts[num];
        }

        public string GetRandomPromptWithStyle()
        {
            int num = _random.Next(1, _promptsRepository.Prompts.Count);
            return _promptsRepository.Prompts[num] + " in the style of " + GetRandomStyle();
        }

        public string GetRandomStyle()
        {
            int num = _random.Next(1, _promptsRepository.Styles.Count);
            return _promptsRepository.Styles[num];
        }

        public string GetRandomNoun()
        {
            int num = _random.Next(1,_promptsRepository.Nouns.Count);
            return _promptsRepository.Nouns[num];
        }

        public string GetRandomVerb()
        {
            int num = _random.Next(1, _promptsRepository.Verbs.Count);
            return _promptsRepository.Verbs[num];
        }

        public string GetRandomAdjective()
        {
            int num = _random.Next(1, _promptsRepository.Adjectives.Count);
            return _promptsRepository.Adjectives[num];
        }

        public string GetRandomLocation()
        {
            int num = _random.Next(1,_promptsRepository.Locations.Count);
            return _promptsRepository.Locations[num];
        }

        public string GetRandomFood()
        {
            int num = _random.Next(1,_promptsRepository.Food.Count);
            return _promptsRepository.Food[num];
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
            existingGame.Round.Solutions = new List<Solution>();
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

        private string ReplaceFirst(string input, string oldString, string newString)
        {
            int i = input.IndexOf(oldString);
            if (i < 0)
            {
                return input;
            }
            return input.Substring(0, i) + newString + input.Substring(i + oldString.Length);
        }

        public async Task AddSolution(string gameId, string playerId, SolveRequest solveRequest)
        {
            // Get the game
            var existingGame = await _gameRepository.GetGameAsync(gameId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }

            var player = existingGame.Players.SingleOrDefault(p => p.Id == playerId);
            if (player == null)
            {
                throw new Exception($"Could not find the player with id {playerId} for game {gameId}");
            }

            // Use the template to fill in the prompt
            // Example: "I want to {VERB} with the {NOUN}"
            var regex = new Regex(@"({[^{}]+})");
            var matches = regex.Matches(existingGame.Round.Template);

            var prompt = existingGame.Round.Template;

            // Save the word pairs "NOUN" and "Cat" so you can remove them from the bank
            var wordPairs = new List<KeyValuePair<string, string>>();

            // Replace each match with a different value
            for (int i = 0; i < matches.Count; i++)
            {
                Match match = matches[i];
                var solutionForThisMatch = solveRequest.Words[i];
                prompt = ReplaceFirst(prompt, match.Value, solutionForThisMatch);
                wordPairs.Add(new KeyValuePair<string, string>(match.Value, solutionForThisMatch));
            }

            // Generate AI image with prompt
            var request = new HttpRequestMessage(HttpMethod.Post, "https://morally-rich-beetle.ngrok-free.app/v1/generation/text-to-image");
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("image/png"));

            var aiRequestMessage = AIGenerateRequest.GetDefaultRequest();
            aiRequestMessage.prompt = prompt;
            request.Content = new StringContent(JsonConvert.SerializeObject(aiRequestMessage), System.Text.Encoding.UTF8, "application/json");

            var aiResponse = await _httpClient.SendAsync(request);

            if (!aiResponse.IsSuccessStatusCode)
            {
                // throw?
            }

            byte[] imageBytes = await aiResponse.Content.ReadAsByteArrayAsync();

            // Save byte array to blob storage
            var url = await _imageRepository.Upload(imageBytes, gameId, existingGame.Round.RoundNumber, playerId);

            // Save the blob URL to the game object
            var solution = new Solution
            {
                ImageUrl = url,
                PlayerId = playerId,
                Prompt = prompt,
                Votes = 0
            };

            // Get the game again so we have less of a race condition
            existingGame = await _gameRepository.GetGameAsync(gameId);
            player = existingGame.Players.SingleOrDefault(p => p.Id == playerId);
            if (existingGame == null)
            {
                throw new Exception($"Game with Id {gameId} not found");
            }

            if (existingGame.Round.Solutions == null)
            {
                existingGame.Round.Solutions = new List<Solution> { solution };
            }
            else if (existingGame.Round.Solutions.Exists(p => p.PlayerId == playerId))
            {
                // Replace the solution
                var index = existingGame.Round.Solutions.FindIndex(p => p.PlayerId == playerId);
                if (index >= 0)
                {
                    existingGame.Round.Solutions[index] = solution;
                }
            }
            else
            {
                existingGame.Round.Solutions.Add(solution);
            }

            // Remove the words that were used from the word bank of the player
            foreach (var wordPair in wordPairs)
            {
                switch (wordPair.Key)
                {
                    case "{NOUN}":
                        player.Nouns.Remove(wordPair.Value);
                        player.Nouns.Add(GetRandomNoun());
                        break;
                    case "{VERB}":
                        player.Verbs.Remove(wordPair.Value);
                        player.Verbs.Add(GetRandomVerb());
                        break;
                    case "{LOCATION}":
                        player.Locations.Remove(wordPair.Value);
                        player.Locations.Add(GetRandomLocation());
                        break;
                    case "{FOOD}":
                        player.Foods.Remove(wordPair.Value);
                        player.Foods.Add(GetRandomFood());
                        break;
                    case "{ADJECTIVE}":
                        player.Adjectives.Remove(wordPair.Value);
                        player.Adjectives.Add(GetRandomAdjective());
                        break;
                }
            }

            // Save the game object
            await _gameRepository.SaveGameAsync(existingGame);
        }
        public async Task<List<string>> GetImages()
        {
            return await _imageRepository.GetBlobsAsync();
            
        }
    }
}
