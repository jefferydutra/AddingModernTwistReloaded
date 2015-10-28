namespace MarvelCharacterService.Service
{
    public class CharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfComics { get; set; }
        public int NumberOfSeries { get; set; }
        public string ProfilePage { get; set; }
        public int CharacterTypeId { get; set; }
        public string CharacterTypeName { get; set; }
    }
}