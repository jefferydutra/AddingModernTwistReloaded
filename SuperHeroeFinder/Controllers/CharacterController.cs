using System.Linq;
using System.Web.Http;
using System.Collections.Generic;
using MarvelCharacterService.Service;
using MarvelCharacterService.Models;

namespace SuperHeroeFinder.Controllers
{
    public class CharacterController : ApiController{
        private readonly ICharacterQueryService _characterQueryService;
        public CharacterController(ICharacterQueryService characterQueryService)
        {
            _characterQueryService = characterQueryService;
        }

        public IEnumerable<Character> Get(){
            return _characterQueryService.GetAll();
        }
        public IEnumerable<Character> Get(int id)
        {
            return _characterQueryService
                    .GetAll()
                    .Where(x => x.CharacterType.Id == id);
        }
    }
}
