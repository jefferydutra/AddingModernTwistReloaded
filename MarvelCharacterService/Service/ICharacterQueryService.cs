using System.Collections.Generic;
using MarvelCharacterService.Models;

namespace MarvelCharacterService.Service{
    public interface ICharacterQueryService{
        IEnumerable<Character> GetAll();
    }
}