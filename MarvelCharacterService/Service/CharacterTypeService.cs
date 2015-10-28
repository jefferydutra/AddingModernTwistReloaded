using System.Collections.Generic;
using System.Linq;
using MarvelCharacterService.Models;

namespace MarvelCharacterService.Service
{
    public class CharacterTypeService
    {
        readonly SuperHeroContext _context = new SuperHeroContext();
        public IEnumerable<CharacterType> GetAll()
        {
            return _context.CharacterTypes.ToList();
        }

    }
}