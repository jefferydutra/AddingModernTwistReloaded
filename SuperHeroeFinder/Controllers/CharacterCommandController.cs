using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using MarvelCharacterService.Service;
using MarvelCharacterService.Service.Messages;

namespace SuperHeroeFinder.Controllers
{
    public class CharacterCommandController : ApiController
    {
        private readonly ICharacterCommandService _characterCommandService;
        public CharacterCommandController(ICharacterCommandService characterCommandService)
        {
            _characterCommandService = characterCommandService;
        }
        public async Task<IHttpActionResult> Put(UpdateCharacterRequest request)
        {
            await _characterCommandService.Update(request);

            return StatusCode(HttpStatusCode.NoContent);
        }

        public async Task<IHttpActionResult> Post(AddCharacterRequest request)
        {
            var response = await _characterCommandService.Add(request);

            return Ok(response.Character);
        }
        public async Task<IHttpActionResult> Delete(int id)
        {
            var request = new RemoveCharacterRequest{Id = id};
            await _characterCommandService.Remove(request);

            return Ok();
        }

    }
}