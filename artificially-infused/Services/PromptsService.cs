using artificially_infused.Controllers.game;


namespace artificially_infused.Services
{
    public class PromptsService
    {
        private readonly PromptsRepository _promptsRepository;
        public PromptsService(PromptsRepository gameRepo)
        {
            _promptsRepository = gameRepo;
        }

        public string getRandomPrompt()
        {
            Random rnd = new Random();
            int num = rnd.Next(_promptsRepository.Prompts.Count);
            return _promptsRepository.Prompts[num];
        }

    }
}
