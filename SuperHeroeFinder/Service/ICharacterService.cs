using System.Collections.Generic;
using SuperHeroeFinder.Model;

namespace SuperHeroeFinder.Service{
    public interface ICharacterService{
        IEnumerable<Character> GetAll();
    }
}