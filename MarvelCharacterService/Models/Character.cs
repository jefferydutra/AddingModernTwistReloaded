namespace MarvelCharacterService.Models{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfComics { get; set; }
        public int NumberOfSeries { get; set; }
        public string ProfilePage { get; set; }
        public CharacterType CharacterType { get; set; }
    }
}