namespace SuperHeroeFinder.Service.Messages
{
    public class AddCharacterResponse
    {
        public bool Success { get; set; }
        public CharacterDto Character { get; set; }
    }
}