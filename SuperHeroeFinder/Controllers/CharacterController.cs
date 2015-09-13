using System.Linq;
using System.Web.Http;
using System.Collections.Generic;
using SuperHeroeFinder.Model;
using SuperHeroeFinder.Service;

namespace SuperHeroeFinder.Controllers
{
    public class CharacterController : ApiController{
        private readonly ICharacterService _characterService;
        public CharacterController(){
            _characterService = new CharacterService();
        }

        public IEnumerable<Character> Get(){
            return _characterService.GetAll();
        }
        public IEnumerable<Character> Get(int id)
        {
            return _characterService
                    .GetAll()
                    .Where(x => (int)x.CharacterType == id);
        }
    }
}
