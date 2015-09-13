using System.Collections.Generic;
using SuperHeroeFinder.Model;

namespace SuperHeroeFinder.Service
{
    public class CharacterService : ICharacterService{
        private readonly IEnumerable<Character> _characters = new List<Character>{
            new Character{
                Id = 1,
                Name = "Wolverine",
                NumberOfComics = 1794,
                NumberOfSeries = 436,
                CharacterType = CharacterType.GoesBothWays,
                ProfilePage = "http://marvel.com/characters/66/wolverine?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character{
                Id = 2,
                Name = "Cyclops",
                NumberOfComics = 697,
                NumberOfSeries = 214,
                CharacterType = CharacterType.Hero,
                ProfilePage = "http://marvel.com/characters/10/cyclops?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character{
                Id = 3,
                Name = "Loki",
                NumberOfComics = 187,
                NumberOfSeries = 77,
                CharacterType = CharacterType.Villian,
                ProfilePage = "http://marvel.com/characters/33/loki?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character{
                Id = 4,
                Name = "SpiderMan",
                NumberOfComics = 2575,
                NumberOfSeries = 531,
                CharacterType = CharacterType.Hero,
                ProfilePage = "http://marvel.com/characters/54/spider-man?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            },
            new Character{
                Id = 5,
                Name = "Magneto",
                NumberOfComics = 249,
                NumberOfSeries = 111,
                CharacterType = CharacterType.GoesBothWays,
                ProfilePage = "http://marvel.com/characters/35/magneto?utm_campaign=apiRef&utm_source=a346c95988e8d81ce986d98fbd99033a"
            }
        };


        public IEnumerable<Character> GetAll(){
            return _characters;
        }
    }
}