using System.Data.Entity;

namespace MarvelCharacterService.Models
{
    public class SuperHeroContext:DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterType> CharacterTypes { get; set; }

    }
}