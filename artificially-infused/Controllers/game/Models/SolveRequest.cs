namespace artificially_infused.Controllers.game.Models
{
    /// <summary>
    /// {
    /// "words" [
    ///         "ski",
    ///         "monkey"
    ///     ]
    /// }
    /// </summary>
    public class SolveRequest
    {
        public string[] Words { get; set; }
    }
}
