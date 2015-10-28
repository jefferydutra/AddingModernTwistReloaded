using System.Collections.Generic;
using SuperHeroeFinder.Models;

namespace SuperHeroeFinder.Service{
    public interface ICharacterQueryService{
        IEnumerable<Character> GetAll();
    }
}