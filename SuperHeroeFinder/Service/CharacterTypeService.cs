using System.Collections.Generic;
using System.Linq;
using SuperHeroeFinder.Models;

namespace SuperHeroeFinder.Service
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