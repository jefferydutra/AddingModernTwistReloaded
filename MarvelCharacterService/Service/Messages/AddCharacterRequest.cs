namespace MarvelCharacterService.Service.Messages
{
    public class AddCharacterRequest
    {
        public string Name { get; set; }
        public int NumberOfComics { get; set; }
        public int NumberOfSeries { get; set; }
        public string ProfilePage { get; set; }
        public int CharacterTypeId { get; set; }

    }
}