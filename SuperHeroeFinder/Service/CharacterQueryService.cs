using System.Collections.Generic;
using System.Linq;
using SuperHeroeFinder.Models;

namespace SuperHeroeFinder.Service
{
    public class CharacterQueryService : ICharacterQueryService{
        readonly SuperHeroContext _context = new SuperHeroContext();

        public IEnumerable<Character> GetAll()
        {
            return _context.Characters.ToList();
        }
    }
}